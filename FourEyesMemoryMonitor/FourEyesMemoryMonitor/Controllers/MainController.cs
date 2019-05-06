// Controller class that handles logical portion of the app

using FourEyesMemoryMonitor.Models;
using FourEyesMemoryMonitor.Views;
using FourEyesMemoryMonitor.Views.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourEyesMemoryMonitor.Controllers
{
    public class MainController
    {
        // App defaults
        private const string DEFAULT_PROCESS_NAME = "";
        private const int DEFAULT_MEMORY_THRESHOLD = 500;
        private const int DEFAULT_OPACITY_VALUE = 100;
        private const int DEFAULT_POLL_INTERVAL = 2;

        // Constant values
        private const int BYTES_PER_MEBIBYTE = 1048576;
        private const string MESSAGE_RAM_USAGE = " RAM USAGE: ";

        // Main View
        public MainWindow AppWindow { get; set; }

        // Sub views/controls
        private ControlPanel _ControlPanel;
        private Overlay _Overlay;
        private NotifyIcon _TrayIcon;
        private AboutPage _AboutPage;

        // Data model
        private TargetModel target;

        // Update timer (Forms so UI can be updated)
        private Timer pollTimer;

        // Keeps overlay on even if RAM is below threshold
        private bool forceOverlayOn = true;

        public MainController()
        {
            AppInit();
        }

        // Set up views and bind events
        private void AppInit()
        {
            AppWindow = new MainWindow();

            _ControlPanel = new ControlPanel();
            _Overlay = new Overlay();
            _TrayIcon = new NotifyIcon();
            _AboutPage = new AboutPage();
            _TrayIcon.Icon = Properties.Resources.FourEyesIcon;
            _TrayIcon.Visible = true;
            _TrayIcon.ContextMenuStrip = AppWindow.TrayMenu;

            AppWindow.Controls.Add(_ControlPanel);

            CreateModel();
            _ControlPanel.UpdateUI(target);

            pollTimer = new Timer();
            pollTimer.Interval = target.PollInterval;

            _Overlay.Opacity = (target.Opacity / 100.0);

            AppWindow.OnWindowHide += AppWindow_OnWindowHide;
            AppWindow.OnShowFromTray += AppWindow_OnShowFromTray;
            AppWindow.OnAboutFromTray += AppWindow_OnAboutFromTray;
            AppWindow.OnCloseFromTray += AppWindow_OnCloseFromTray;
            AppWindow.Load += AppWindow_Load;
            pollTimer.Tick += PollTimer_Tick;
            _ControlPanel.OnProcessNameChanged += _ControlPanel_OnProcessNameChanged;
            _ControlPanel.OnControlChange += _ControlPanel_OnControlChange;
            _TrayIcon.DoubleClick += _TrayIcon_DoubleClick;

            pollTimer.Start();
        }        

        // Create a model from preferences or use a default
        private void CreateModel()
        {
            // Create the model from user settings if present or default settings if not
            var settings = Properties.Settings.Default;

            target = new TargetModel();
            target.ProcessName = settings.ProcessName != "" ? settings.ProcessName : DEFAULT_PROCESS_NAME;
            target.MemoryThreshold = settings.MemoryThreshold != -1 ? settings.MemoryThreshold : DEFAULT_MEMORY_THRESHOLD;
            target.Opacity = settings.Opacity != -1 ? settings.Opacity : DEFAULT_OPACITY_VALUE;
            target.PollInterval = settings.PollInterval != -1 ? settings.PollInterval : DEFAULT_POLL_INTERVAL;
            target.ProcessFound = FindProcess(target.ProcessName);
        }

        // Helper method to see if a process exists
        private bool FindProcess(string name)
        {
            Process[] target = Process.GetProcessesByName(name);
            return target.Length > 0;
        }

        // Checks if the process memory is above the threshold and reacts accordingly
        private void PollTimer_Tick(object sender, EventArgs e)
        {

            if (FindProcess(target.ProcessName))
            {
                Process[] processes = Process.GetProcessesByName(target.ProcessName);
                bool procOverThresh = false;
                long peakProc = 0;
                foreach (Process proc in processes)
                {
                    long thresh = target.MemoryThreshold * BYTES_PER_MEBIBYTE;
                    long mem = 0;

                    PerformanceCounter PC = new PerformanceCounter();
                    PC.CategoryName = "Process";
                    PC.CounterName = "Working Set - Private";
                    PC.InstanceName = proc.ProcessName;

                    try
                    {
                        mem = (long)PC.NextValue();
                    }
                    catch(InvalidOperationException ex)
                    {
                        mem = 0;
                    }
                    


                    PC.Close();
                    PC.Dispose();


                    if (mem > peakProc)
                    {
                        peakProc = mem;
                    }

                    if (mem >= thresh)
                    {
                        procOverThresh = true;
                    }
                }

                target.ProcessPeakMB = (int)(peakProc / BYTES_PER_MEBIBYTE);
                _Overlay.MessageText = target.ProcessName.ToUpper() + MESSAGE_RAM_USAGE + target.ProcessPeakMB + " MB";

                if (procOverThresh || forceOverlayOn)
                {
                    _Overlay.Show();
                }
                else
                {
                    _Overlay.Hide();
                }
            }
            else
            {
                target.ProcessFound = false;                
                _ControlPanel.UpdateUI(target);
                if (!forceOverlayOn)
                {
                    _Overlay.Hide();
                }
            }
        }

        //----------------
        // Event Handlers
        //----------------
        private void _TrayIcon_DoubleClick(object sender, EventArgs e)
        {
            AppWindow_OnShowFromTray();
        }

        private void _ControlPanel_OnProcessNameChanged(string processName)
        {
            var settings = Properties.Settings.Default;

            // Update model process name and persist to settings
            target.ProcessFound = FindProcess(processName);
            target.ProcessName = processName;
            settings.ProcessName = processName;

            // Update UI
            _ControlPanel.UpdateUI(target);

            // Persist edited settings
            settings.Save();
        }

        private void _ControlPanel_OnControlChange(int threshold, int opacity, int pollInterval)
        {
            var settings = Properties.Settings.Default;

            // Update model threshold and persist to settings
            target.MemoryThreshold = threshold;
            settings.MemoryThreshold = threshold;            

            // Update model opacity and persist to settings
            target.Opacity = opacity;
            settings.Opacity = opacity;
            _Overlay.Opacity = (target.Opacity / 100.0);

            // Update model poll interval and persist to settings
            target.PollInterval = pollInterval;
            settings.PollInterval = pollInterval;
            pollTimer.Interval = pollInterval * 1000;

            // Update UI
            _ControlPanel.UpdateUI(target);

            // Save edited settings
            settings.Save();
        }

        private void AppWindow_Load(object sender, EventArgs e)
        {
            var settings = Properties.Settings.Default;
            if (settings.ControlPanelHidden)
            {
                AppWindow_OnWindowHide();
            }
        }

        private void AppWindow_OnWindowHide()
        {
            var settings = Properties.Settings.Default;
            AppWindow.ShowInTaskbar = false;
            AppWindow.Hide();
            forceOverlayOn = false;
            settings.ControlPanelHidden = true;
            settings.Save();
        }

        private void AppWindow_OnShowFromTray()
        {
            var settings = Properties.Settings.Default;
            AppWindow.ShowInTaskbar = true;
            AppWindow.Show();
            AppWindow.WindowState = FormWindowState.Normal;
            forceOverlayOn = true;
            settings.ControlPanelHidden = false;
            settings.Save();
        }

        private void AppWindow_OnAboutFromTray()
        {
            _AboutPage.ShowDialog(_ControlPanel);
        }

        private void AppWindow_OnCloseFromTray()
        {
            _TrayIcon.Visible = false;
            _TrayIcon.Dispose();
            pollTimer.Enabled = false;
            pollTimer.Dispose();
            System.Environment.Exit(0);
        }
    }
}
