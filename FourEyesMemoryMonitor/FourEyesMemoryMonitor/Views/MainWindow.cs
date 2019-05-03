using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourEyesMemoryMonitor
{
    public partial class MainWindow : Form
    {
        public delegate void WindowHiddenHandler();
        public event WindowHiddenHandler OnWindowHide;

        public delegate void TrayShowControlHandler();
        public event TrayShowControlHandler OnShowFromTray;

        public delegate void TrayShowAboutHandler();
        public event TrayShowAboutHandler OnAboutFromTray;

        public delegate void TrayCloseAppHandler();
        public event TrayCloseAppHandler OnCloseFromTray;

        public ContextMenuStrip TrayMenu { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.FourEyesIcon;
            this.FormClosing += MainWindow_FormClosing;

            tmi_ShowControlPanel.Click += Tmi_ShowControlPanel_Click;
            tmi_About.Click += Tmi_About_Click;
            tmi_Close.Click += Tmi_Close_Click;

            TrayMenu = ctm_TrayMenu;
        }


        private void Tmi_ShowControlPanel_Click(object sender, EventArgs e)
        {
            OnShowFromTray?.Invoke();
        }

        private void Tmi_About_Click(object sender, EventArgs e)
        {
            OnAboutFromTray?.Invoke();
        }

        private void Tmi_Close_Click(object sender, EventArgs e)
        {
            OnCloseFromTray?.Invoke();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                OnWindowHide?.Invoke();
                e.Cancel = true;
            }
        }
    }
}
