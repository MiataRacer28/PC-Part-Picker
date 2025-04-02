namespace PCPartPicker
{
    partial class PCBuildScreen
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
            this.CPUSelect = new System.Windows.Forms.Button();
            this.MBSelect = new System.Windows.Forms.Button();
            this.GPUSelect = new System.Windows.Forms.Button();
            this.ToMainMenu = new System.Windows.Forms.Button();
            this.ramSelect = new System.Windows.Forms.Button();
            this.gpuList = new System.Windows.Forms.ListBox();
            this.cpuList = new System.Windows.Forms.ListBox();
            this.ramList = new System.Windows.Forms.ListBox();
            this.motherboardList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CPUSelect
            // 
            this.CPUSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUSelect.Location = new System.Drawing.Point(918, 191);
            this.CPUSelect.Name = "CPUSelect";
            this.CPUSelect.Size = new System.Drawing.Size(424, 63);
            this.CPUSelect.TabIndex = 0;
            this.CPUSelect.Text = "Select CPU";
            this.CPUSelect.UseVisualStyleBackColor = true;
            this.CPUSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // MBSelect
            // 
            this.MBSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MBSelect.Location = new System.Drawing.Point(114, 587);
            this.MBSelect.Name = "MBSelect";
            this.MBSelect.Size = new System.Drawing.Size(419, 63);
            this.MBSelect.TabIndex = 1;
            this.MBSelect.Text = "Select Motherboard";
            this.MBSelect.UseVisualStyleBackColor = true;
            this.MBSelect.Click += new System.EventHandler(this.MBSelect_Click);
            // 
            // GPUSelect
            // 
            this.GPUSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPUSelect.Location = new System.Drawing.Point(114, 191);
            this.GPUSelect.Name = "GPUSelect";
            this.GPUSelect.Size = new System.Drawing.Size(424, 63);
            this.GPUSelect.TabIndex = 2;
            this.GPUSelect.Text = "Select GPU";
            this.GPUSelect.UseVisualStyleBackColor = true;
            this.GPUSelect.Click += new System.EventHandler(this.GPUSelect_Click);
            // 
            // ToMainMenu
            // 
            this.ToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToMainMenu.Location = new System.Drawing.Point(473, 993);
            this.ToMainMenu.Name = "ToMainMenu";
            this.ToMainMenu.Size = new System.Drawing.Size(500, 60);
            this.ToMainMenu.TabIndex = 3;
            this.ToMainMenu.Text = "Main Menu";
            this.ToMainMenu.UseVisualStyleBackColor = true;
            this.ToMainMenu.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ramSelect
            // 
            this.ramSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramSelect.Location = new System.Drawing.Point(918, 587);
            this.ramSelect.Name = "ramSelect";
            this.ramSelect.Size = new System.Drawing.Size(424, 63);
            this.ramSelect.TabIndex = 4;
            this.ramSelect.Text = "Select RAM";
            this.ramSelect.UseVisualStyleBackColor = true;
            this.ramSelect.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // gpuList
            // 
            this.gpuList.FormattingEnabled = true;
            this.gpuList.ItemHeight = 29;
            this.gpuList.Location = new System.Drawing.Point(114, 273);
            this.gpuList.Name = "gpuList";
            this.gpuList.Size = new System.Drawing.Size(424, 178);
            this.gpuList.TabIndex = 5;
            // 
            // cpuList
            // 
            this.cpuList.FormattingEnabled = true;
            this.cpuList.ItemHeight = 29;
            this.cpuList.Location = new System.Drawing.Point(918, 273);
            this.cpuList.Name = "cpuList";
            this.cpuList.Size = new System.Drawing.Size(424, 178);
            this.cpuList.TabIndex = 6;
            // 
            // ramList
            // 
            this.ramList.FormattingEnabled = true;
            this.ramList.ItemHeight = 29;
            this.ramList.Location = new System.Drawing.Point(918, 669);
            this.ramList.Name = "ramList";
            this.ramList.Size = new System.Drawing.Size(424, 178);
            this.ramList.TabIndex = 7;
            // 
            // motherboardList
            // 
            this.motherboardList.FormattingEnabled = true;
            this.motherboardList.ItemHeight = 29;
            this.motherboardList.Location = new System.Drawing.Point(114, 669);
            this.motherboardList.Name = "motherboardList";
            this.motherboardList.Size = new System.Drawing.Size(419, 178);
            this.motherboardList.TabIndex = 8;
            // 
            // PCBuildScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1472, 1121);
            this.Controls.Add(this.motherboardList);
            this.Controls.Add(this.ramList);
            this.Controls.Add(this.cpuList);
            this.Controls.Add(this.gpuList);
            this.Controls.Add(this.ramSelect);
            this.Controls.Add(this.ToMainMenu);
            this.Controls.Add(this.GPUSelect);
            this.Controls.Add(this.MBSelect);
            this.Controls.Add(this.CPUSelect);
            this.Name = "PCBuildScreen";
            this.Text = "PCBuildScreen";
            this.Load += new System.EventHandler(this.PCBuildScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CPUSelect;
        private System.Windows.Forms.Button MBSelect;
        private System.Windows.Forms.Button GPUSelect;
        private System.Windows.Forms.Button ToMainMenu;
        private System.Windows.Forms.Button ramSelect;
        private System.Windows.Forms.ListBox gpuList;
        private System.Windows.Forms.ListBox cpuList;
        private System.Windows.Forms.ListBox ramList;
        private System.Windows.Forms.ListBox motherboardList;
    }
}