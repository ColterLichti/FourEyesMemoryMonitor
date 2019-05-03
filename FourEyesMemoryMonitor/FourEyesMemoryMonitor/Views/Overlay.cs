// Stripped down form acting as a message overlay
// Displays in the top center of the main monitor

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourEyesMemoryMonitor.Views
{
    public partial class Overlay : Form
    {
        // Sets the message that will display in the overlay
        public string MessageText
        {
            get
            {
                return Message.Text;
            }
            set
            {
                Message.Text = value;
            }
        }

        public Overlay()
        {
            InitializeComponent();
            Position();
            this.SizeChanged += Overlay_SizeChanged;
        }

        // Reposition if the size changes
        private void Overlay_SizeChanged(object sender, EventArgs e)
        {
            Position();
        }

        // Position overlay in top center of main monitor
        private void Position()
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, 2);
        }
    }
}
