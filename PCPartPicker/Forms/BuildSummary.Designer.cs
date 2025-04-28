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
            this.Cpu = new System.Windows.Forms.TextBox();
            this.Gpu = new System.Windows.Forms.TextBox();
            this.Ram = new System.Windows.Forms.TextBox();
            this.Mobo = new System.Windows.Forms.TextBox();
            this.BuildSum = new System.Windows.Forms.TextBox();
            this.mainMenu = new System.Windows.Forms.Button();
            this.PerformanceScore = new System.Windows.Forms.TextBox();
            this.PerformanceScoreText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CpuSum
            // 
            this.CpuSum.Location = new System.Drawing.Point(79, 987);
            this.CpuSum.MinimumSize = new System.Drawing.Size(500, 200);
            this.CpuSum.Multiline = true;
            this.CpuSum.Name = "CpuSum";
            this.CpuSum.ReadOnly = true;
            this.CpuSum.Size = new System.Drawing.Size(500, 200);
            this.CpuSum.TabIndex = 0;
            // 
            // RamSum
            // 
            this.RamSum.Location = new System.Drawing.Point(731, 709);
            this.RamSum.MinimumSize = new System.Drawing.Size(500, 200);
            this.RamSum.Multiline = true;
            this.RamSum.Name = "RamSum";
            this.RamSum.ReadOnly = true;
            this.RamSum.Size = new System.Drawing.Size(500, 200);
            this.RamSum.TabIndex = 1;
            // 
            // GpuSum
            // 
            this.GpuSum.Location = new System.Drawing.Point(731, 987);
            this.GpuSum.MinimumSize = new System.Drawing.Size(500, 200);
            this.GpuSum.Multiline = true;
            this.GpuSum.Name = "GpuSum";
            this.GpuSum.ReadOnly = true;
            this.GpuSum.Size = new System.Drawing.Size(500, 200);
            this.GpuSum.TabIndex = 2;
            // 
            // MoboSum
            // 
            this.MoboSum.Location = new System.Drawing.Point(79, 709);
            this.MoboSum.MinimumSize = new System.Drawing.Size(500, 200);
            this.MoboSum.Multiline = true;
            this.MoboSum.Name = "MoboSum";
            this.MoboSum.ReadOnly = true;
            this.MoboSum.Size = new System.Drawing.Size(500, 200);
            this.MoboSum.TabIndex = 3;
            // 
            // Cpu
            // 
            this.Cpu.Location = new System.Drawing.Point(1335, 95);
            this.Cpu.Name = "Cpu";
            this.Cpu.ReadOnly = true;
            this.Cpu.Size = new System.Drawing.Size(400, 35);
            this.Cpu.TabIndex = 5;
            // 
            // Gpu
            // 
            this.Gpu.Location = new System.Drawing.Point(1335, 218);
            this.Gpu.Name = "Gpu";
            this.Gpu.ReadOnly = true;
            this.Gpu.Size = new System.Drawing.Size(400, 35);
            this.Gpu.TabIndex = 6;
            // 
            // Ram
            // 
            this.Ram.Location = new System.Drawing.Point(1335, 360);
            this.Ram.Name = "Ram";
            this.Ram.ReadOnly = true;
            this.Ram.Size = new System.Drawing.Size(400, 35);
            this.Ram.TabIndex = 7;
            // 
            // Mobo
            // 
            this.Mobo.Location = new System.Drawing.Point(1335, 492);
            this.Mobo.Name = "Mobo";
            this.Mobo.ReadOnly = true;
            this.Mobo.Size = new System.Drawing.Size(400, 35);
            this.Mobo.TabIndex = 8;
            // 
            // BuildSum
            // 
            this.BuildSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuildSum.Location = new System.Drawing.Point(79, 95);
            this.BuildSum.MinimumSize = new System.Drawing.Size(1152, 500);
            this.BuildSum.Multiline = true;
            this.BuildSum.Name = "BuildSum";
            this.BuildSum.ReadOnly = true;
            this.BuildSum.Size = new System.Drawing.Size(1152, 500);
            this.BuildSum.TabIndex = 9;
            this.BuildSum.TextChanged += new System.EventHandler(this.BuildSum_TextChanged_1);
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.Turquoise;
            this.mainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.Location = new System.Drawing.Point(1335, 709);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(529, 478);
            this.mainMenu.TabIndex = 10;
            this.mainMenu.Text = "Return to Menu";
            this.mainMenu.UseVisualStyleBackColor = false;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // PerformanceScore
            // 
            this.PerformanceScore.Location = new System.Drawing.Point(1456, 544);
            this.PerformanceScore.Name = "PerformanceScore";
            this.PerformanceScore.Size = new System.Drawing.Size(0, 35);
            this.PerformanceScore.TabIndex = 11;
            // 
            // PerformanceScoreText
            // 
            this.PerformanceScoreText.Location = new System.Drawing.Point(1335, 610);
            this.PerformanceScoreText.MaximumSize = new System.Drawing.Size(250, 50);
            this.PerformanceScoreText.MinimumSize = new System.Drawing.Size(75, 50);
            this.PerformanceScoreText.Name = "PerformanceScoreText";
            this.PerformanceScoreText.ReadOnly = true;
            this.PerformanceScoreText.Size = new System.Drawing.Size(250, 35);
            this.PerformanceScoreText.TabIndex = 12;
            // 
            // BuildSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1922, 1421);
            this.Controls.Add(this.PerformanceScoreText);
            this.Controls.Add(this.PerformanceScore);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.BuildSum);
            this.Controls.Add(this.Mobo);
            this.Controls.Add(this.Ram);
            this.Controls.Add(this.Gpu);
            this.Controls.Add(this.Cpu);
            this.Controls.Add(this.MoboSum);
            this.Controls.Add(this.GpuSum);
            this.Controls.Add(this.RamSum);
            this.Controls.Add(this.CpuSum);
            this.MinimumSize = new System.Drawing.Size(1950, 1500);
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
        private System.Windows.Forms.TextBox Cpu;
        private System.Windows.Forms.TextBox Gpu;
        private System.Windows.Forms.TextBox Ram;
        private System.Windows.Forms.TextBox Mobo;
        private System.Windows.Forms.TextBox BuildSum;
        private System.Windows.Forms.Button mainMenu;
        private System.Windows.Forms.TextBox PerformanceScore;
        private System.Windows.Forms.TextBox PerformanceScoreText;
    }
}