using FourEyesMemoryMonitor.Models;
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

        public Form AppWindow { get; set; }

        private ControlPanel _ControlPanel;
        private TargetModel target;

        private Timer pollTimer;

        public MainController()
        {
            AppInit();
        }

        private void AppInit()
        {
            AppWindow = new MainWindow();
            _ControlPanel = new ControlPanel();
            AppWindow.Controls.Add(_ControlPanel);

            CreateModel();
            _ControlPanel.UpdateUI(target);

            pollTimer = new Timer();
            pollTimer.Interval = target.PollInterval;
            pollTimer.Tick += PollTimer_Tick;
            pollTimer.Start();

            _ControlPanel.OnProcessNameChanged += _ControlPanel_OnProcessNameChanged;
            _ControlPanel.OnControlChange += _ControlPanel_OnControlChange;
        }


        private void _ControlPanel_OnProcessNameChanged(string processName)
        {
            target.ProcessFound = FindProcess(processName);
            target.ProcessName = processName;
            _ControlPanel.UpdateUI(target);
        }

        private void _ControlPanel_OnControlChange(int threshold, int opacity, int pollInterval)
        {
            
        }


        private void PollTimer_Tick(object sender, EventArgs e)
        {
            // Update logic here
        }

        private void CreateModel()
        {
            // Create the model from user settings if present or default settings if not
            var def = Properties.Settings.Default;
            var user = Properties.User.Default;

            target = new TargetModel();
            target.ProcessName = user.ProcessName != "" ? user.ProcessName : def.ProcessName;
            target.MemoryThreshold = user.MemoryThreshold != -1 ? user.MemoryThreshold : def.MemoryThreshold;
            target.Opacity = user.Opacity != -1 ? user.Opacity : def.Opacity;
            target.PollInterval = user.PollInterval != -1 ? user.PollInterval : def.PollInterval;
            target.ProcessFound = FindProcess(target.ProcessName);
        }

        private bool FindProcess(string name)
        {
            Process[] target = Process.GetProcessesByName(name);
            return target.Length > 0;
        }
    }
}
