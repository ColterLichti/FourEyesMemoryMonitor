using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FourEyesMemoryMonitor.Models;

namespace FourEyesMemoryMonitor.Views.Controls
{
    public partial class ControlPanel : UserControl
    {
        public delegate void ProcessNameChangeHandler(string processName);
        public delegate void ControlChangeHandler(int threshold, int opacity, int pollInterval);

        public event ProcessNameChangeHandler OnProcessNameChanged;
        public event ControlChangeHandler OnControlChange;

        public ControlPanel()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            txt_ProcessName.TextChanged += Txt_ProcessName_TextChanged;
            ns_MemoryThreshold.ValueChanged += Ns_MemoryThreshold_ValueChanged;
            ns_Opacity.ValueChanged += Ns_Opacity_ValueChanged;
            ns_PollInterval.ValueChanged += Ns_PollInterval_ValueChanged;
        }

        private void Ns_PollInterval_ValueChanged(object sender, EventArgs e)
        {
            OnControlChange?.Invoke((int)ns_MemoryThreshold.Value, (int)ns_Opacity.Value, (int)ns_PollInterval.Value);
        }

        private void Ns_Opacity_ValueChanged(object sender, EventArgs e)
        {
            OnControlChange?.Invoke((int)ns_MemoryThreshold.Value, (int)ns_Opacity.Value, (int)ns_PollInterval.Value);
        }

        private void Ns_MemoryThreshold_ValueChanged(object sender, EventArgs e)
        {
            OnControlChange?.Invoke((int)ns_MemoryThreshold.Value, (int)ns_Opacity.Value, (int)ns_PollInterval.Value);
        }

        private void Txt_ProcessName_TextChanged(object sender, EventArgs e)
        {
            TextBox field = (TextBox)sender;
            OnProcessNameChanged?.Invoke(field.Text);
        }

        public void UpdateUI(TargetModel model)
        {
            txt_ProcessName.Text = model.ProcessName;
            ns_MemoryThreshold.Value = model.MemoryThreshold;
            ns_Opacity.Value = model.Opacity;
            ns_PollInterval.Value = model.PollInterval;
            SetFoundIndicator(model.ProcessFound);
        }

        private void SetFoundIndicator(bool found)
        {
            if (found)
            {
                lbl_TargetStatus.Text = "RUNNING";
                lbl_TargetStatus.ForeColor = Color.Green;
            }
            else
            {
                lbl_TargetStatus.Text = "N/F";
                lbl_TargetStatus.ForeColor = Color.Red;
            }
        }

    }
}
