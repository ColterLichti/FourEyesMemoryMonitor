namespace FourEyesMemoryMonitor
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ctm_TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmi_ShowControlPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.tmi_About = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tmi_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.ctm_TrayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctm_TrayMenu
            // 
            this.ctm_TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmi_ShowControlPanel,
            this.tmi_About,
            this.toolStripSeparator1,
            this.tmi_Close});
            this.ctm_TrayMenu.Name = "ctm_TrayMenu";
            this.ctm_TrayMenu.Size = new System.Drawing.Size(168, 76);
            // 
            // tmi_ShowControlPanel
            // 
            this.tmi_ShowControlPanel.Image = global::FourEyesMemoryMonitor.Properties.Resources.Control_16x;
            this.tmi_ShowControlPanel.Name = "tmi_ShowControlPanel";
            this.tmi_ShowControlPanel.Size = new System.Drawing.Size(167, 22);
            this.tmi_ShowControlPanel.Text = "Show Control Panel";
            // 
            // tmi_About
            // 
            this.tmi_About.Image = global::FourEyesMemoryMonitor.Properties.Resources.Question_16x;
            this.tmi_About.Name = "tmi_About";
            this.tmi_About.Size = new System.Drawing.Size(167, 22);
            this.tmi_About.Text = "About";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // tmi_Close
            // 
            this.tmi_Close.Image = global::FourEyesMemoryMonitor.Properties.Resources.Close_red_16x;
            this.tmi_Close.Name = "tmi_Close";
            this.tmi_Close.Size = new System.Drawing.Size(167, 22);
            this.tmi_Close.Text = "Close";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(342, 125);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 150);
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FourEyes - Control Panel";
            this.ctm_TrayMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip ctm_TrayMenu;
        private System.Windows.Forms.ToolStripMenuItem tmi_ShowControlPanel;
        private System.Windows.Forms.ToolStripMenuItem tmi_About;
        private System.Windows.Forms.ToolStripMenuItem tmi_Close;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

