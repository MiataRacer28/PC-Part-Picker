namespace PCPartPicker.Models
{
    partial class BuildSummary
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
            this.CpuSum = new System.Windows.Forms.TextBox();
            this.RamSum = new System.Windows.Forms.TextBox();
            this.GpuSum = new System.Windows.Forms.TextBox();
            this.MoboSum = new System.Windows.Forms.TextBox();
            this.BuildSum = new System.Windows.Forms.TextBox();
            this.Cpu = new System.Windows.Forms.TextBox();
            this.Gpu = new System.Windows.Forms.TextBox();
            this.Ram = new System.Windows.Forms.TextBox();
            this.Mobo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CpuSum
            // 
            this.CpuSum.Location = new System.Drawing.Point(79, 987);
            this.CpuSum.MaximumSize = new System.Drawing.Size(500, 150);
            this.CpuSum.MinimumSize = new System.Drawing.Size(400, 150);
            this.CpuSum.Name = "CpuSum";
            this.CpuSum.Size = new System.Drawing.Size(500, 150);
            this.CpuSum.TabIndex = 0;
            // 
            // RamSum
            // 
            this.RamSum.Location = new System.Drawing.Point(731, 709);
            this.RamSum.MaximumSize = new System.Drawing.Size(500, 150);
            this.RamSum.MinimumSize = new System.Drawing.Size(500, 150);
            this.RamSum.Name = "RamSum";
            this.RamSum.Size = new System.Drawing.Size(500, 150);
            this.RamSum.TabIndex = 1;
            // 
            // GpuSum
            // 
            this.GpuSum.Location = new System.Drawing.Point(731, 987);
            this.GpuSum.MaximumSize = new System.Drawing.Size(500, 150);
            this.GpuSum.MinimumSize = new System.Drawing.Size(400, 150);
            this.GpuSum.Name = "GpuSum";
            this.GpuSum.Size = new System.Drawing.Size(500, 150);
            this.GpuSum.TabIndex = 2;
            // 
            // MoboSum
            // 
            this.MoboSum.Location = new System.Drawing.Point(79, 709);
            this.MoboSum.MaximumSize = new System.Drawing.Size(500, 150);
            this.MoboSum.MinimumSize = new System.Drawing.Size(400, 150);
            this.MoboSum.Name = "MoboSum";
            this.MoboSum.Size = new System.Drawing.Size(500, 150);
            this.MoboSum.TabIndex = 3;
            // 
            // BuildSum
            // 
            this.BuildSum.Location = new System.Drawing.Point(79, 83);
            this.BuildSum.MinimumSize = new System.Drawing.Size(1000, 500);
            this.BuildSum.Name = "BuildSum";
            this.BuildSum.Size = new System.Drawing.Size(1000, 500);
            this.BuildSum.TabIndex = 4;
            this.BuildSum.TextChanged += new System.EventHandler(this.BuildSum_TextChanged);
            // 
            // Cpu
            // 
            this.Cpu.Location = new System.Drawing.Point(1456, 83);
            this.Cpu.MaximumSize = new System.Drawing.Size(250, 50);
            this.Cpu.MinimumSize = new System.Drawing.Size(75, 50);
            this.Cpu.Name = "Cpu";
            this.Cpu.Size = new System.Drawing.Size(250, 50);
            this.Cpu.TabIndex = 5;
            // 
            // Gpu
            // 
            this.Gpu.Location = new System.Drawing.Point(1456, 204);
            this.Gpu.MaximumSize = new System.Drawing.Size(250, 50);
            this.Gpu.MinimumSize = new System.Drawing.Size(75, 50);
            this.Gpu.Name = "Gpu";
            this.Gpu.Size = new System.Drawing.Size(250, 50);
            this.Gpu.TabIndex = 6;
            // 
            // Ram
            // 
            this.Ram.Location = new System.Drawing.Point(1456, 326);
            this.Ram.MaximumSize = new System.Drawing.Size(250, 50);
            this.Ram.MinimumSize = new System.Drawing.Size(75, 50);
            this.Ram.Name = "Ram";
            this.Ram.Size = new System.Drawing.Size(250, 50);
            this.Ram.TabIndex = 7;
            // 
            // Mobo
            // 
            this.Mobo.Location = new System.Drawing.Point(1456, 456);
            this.Mobo.MaximumSize = new System.Drawing.Size(250, 50);
            this.Mobo.MinimumSize = new System.Drawing.Size(75, 50);
            this.Mobo.Name = "Mobo";
            this.Mobo.Size = new System.Drawing.Size(250, 50);
            this.Mobo.TabIndex = 8;
            // 
            // BuildSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1896, 1327);
            this.Controls.Add(this.Mobo);
            this.Controls.Add(this.Ram);
            this.Controls.Add(this.Gpu);
            this.Controls.Add(this.Cpu);
            this.Controls.Add(this.BuildSum);
            this.Controls.Add(this.MoboSum);
            this.Controls.Add(this.GpuSum);
            this.Controls.Add(this.RamSum);
            this.Controls.Add(this.CpuSum);
            this.Name = "BuildSummary";
            this.Text = "BuildSummary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CpuSum;
        private System.Windows.Forms.TextBox RamSum;
        private System.Windows.Forms.TextBox GpuSum;
        private System.Windows.Forms.TextBox MoboSum;
        private System.Windows.Forms.TextBox BuildSum;
        private System.Windows.Forms.TextBox Cpu;
        private System.Windows.Forms.TextBox Gpu;
        private System.Windows.Forms.TextBox Ram;
        private System.Windows.Forms.TextBox Mobo;
    }
}