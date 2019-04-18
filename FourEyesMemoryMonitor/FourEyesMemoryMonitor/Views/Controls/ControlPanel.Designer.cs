namespace FourEyesMemoryMonitor.Views.Controls
{
    partial class ControlPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ns_Opacity = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ns_PollInterval = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ns_MemoryThreshold = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_TargetStatus = new System.Windows.Forms.Label();
            this.txt_ProcessName = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ns_Opacity)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ns_PollInterval)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ns_MemoryThreshold)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ns_Opacity);
            this.groupBox4.Location = new System.Drawing.Point(110, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(103, 48);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Opacity (%)";
            // 
            // ns_Opacity
            // 
            this.ns_Opacity.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ns_Opacity.Location = new System.Drawing.Point(6, 19);
            this.ns_Opacity.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ns_Opacity.Name = "ns_Opacity";
            this.ns_Opacity.Size = new System.Drawing.Size(91, 23);
            this.ns_Opacity.TabIndex = 1;
            this.ns_Opacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ns_Opacity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ns_PollInterval);
            this.groupBox3.Location = new System.Drawing.Point(218, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(103, 48);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Poll Interval (s)";
            // 
            // ns_PollInterval
            // 
            this.ns_PollInterval.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ns_PollInterval.Location = new System.Drawing.Point(6, 19);
            this.ns_PollInterval.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.ns_PollInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ns_PollInterval.Name = "ns_PollInterval";
            this.ns_PollInterval.Size = new System.Drawing.Size(91, 23);
            this.ns_PollInterval.TabIndex = 1;
            this.ns_PollInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ns_PollInterval.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ns_MemoryThreshold);
            this.groupBox2.Location = new System.Drawing.Point(3, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(103, 48);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Threshold (MB)";
            // 
            // ns_MemoryThreshold
            // 
            this.ns_MemoryThreshold.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ns_MemoryThreshold.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ns_MemoryThreshold.Location = new System.Drawing.Point(6, 19);
            this.ns_MemoryThreshold.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.ns_MemoryThreshold.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ns_MemoryThreshold.Name = "ns_MemoryThreshold";
            this.ns_MemoryThreshold.Size = new System.Drawing.Size(91, 23);
            this.ns_MemoryThreshold.TabIndex = 0;
            this.ns_MemoryThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ns_MemoryThreshold.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_TargetStatus);
            this.groupBox1.Controls.Add(this.txt_ProcessName);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 48);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target Process";
            // 
            // lbl_TargetStatus
            // 
            this.lbl_TargetStatus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TargetStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_TargetStatus.Location = new System.Drawing.Point(248, 16);
            this.lbl_TargetStatus.Name = "lbl_TargetStatus";
            this.lbl_TargetStatus.Size = new System.Drawing.Size(64, 23);
            this.lbl_TargetStatus.TabIndex = 1;
            this.lbl_TargetStatus.Text = "N/F";
            this.lbl_TargetStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ProcessName
            // 
            this.txt_ProcessName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProcessName.Location = new System.Drawing.Point(6, 16);
            this.txt_ProcessName.Name = "txt_ProcessName";
            this.txt_ProcessName.Size = new System.Drawing.Size(236, 23);
            this.txt_ProcessName.TabIndex = 0;
            this.txt_ProcessName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ControlPanel";
            this.Size = new System.Drawing.Size(324, 108);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ns_Opacity)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ns_PollInterval)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ns_MemoryThreshold)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown ns_Opacity;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown ns_PollInterval;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown ns_MemoryThreshold;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_TargetStatus;
        private System.Windows.Forms.TextBox txt_ProcessName;
    }
}
