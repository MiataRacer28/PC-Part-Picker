namespace PCPartPicker.Forms
{
    partial class AddCPU
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
            this.CoreCount = new System.Windows.Forms.TextBox();
            this.clockFrequency = new System.Windows.Forms.TextBox();
            this.maxTDP = new System.Windows.Forms.TextBox();
            this.architecture = new System.Windows.Forms.TextBox();
            this.integratedGPU = new System.Windows.Forms.TextBox();
            this.socket = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.Button();
            this.coreCountEntry = new System.Windows.Forms.TextBox();
            this.clockFreqEntry = new System.Windows.Forms.TextBox();
            this.maxTDPEntry = new System.Windows.Forms.TextBox();
            this.cpuArchEntry = new System.Windows.Forms.TextBox();
            this.intGpuEntry = new System.Windows.Forms.TextBox();
            this.socketEntry = new System.Windows.Forms.TextBox();
            this.pfScoreEntry = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cpuManufacturerEntry = new System.Windows.Forms.TextBox();
            this.Manufacturer = new System.Windows.Forms.TextBox();
            this.cpuNameEntry = new System.Windows.Forms.TextBox();
            this.ramName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CoreCount
            // 
            this.CoreCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoreCount.Location = new System.Drawing.Point(21, 308);
            this.CoreCount.Name = "CoreCount";
            this.CoreCount.ReadOnly = true;
            this.CoreCount.Size = new System.Drawing.Size(404, 55);
            this.CoreCount.TabIndex = 3;
            this.CoreCount.Text = "Enter Core Count:";
            // 
            // clockFrequency
            // 
            this.clockFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockFrequency.Location = new System.Drawing.Point(21, 400);
            this.clockFrequency.Name = "clockFrequency";
            this.clockFrequency.ReadOnly = true;
            this.clockFrequency.Size = new System.Drawing.Size(404, 55);
            this.clockFrequency.TabIndex = 4;
            this.clockFrequency.Text = "Enter Clock Freq:";
            // 
            // maxTDP
            // 
            this.maxTDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTDP.Location = new System.Drawing.Point(21, 492);
            this.maxTDP.Name = "maxTDP";
            this.maxTDP.ReadOnly = true;
            this.maxTDP.Size = new System.Drawing.Size(404, 55);
            this.maxTDP.TabIndex = 5;
            this.maxTDP.Text = "Enter Max TDP:";
            // 
            // architecture
            // 
            this.architecture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.architecture.Location = new System.Drawing.Point(21, 584);
            this.architecture.Name = "architecture";
            this.architecture.ReadOnly = true;
            this.architecture.Size = new System.Drawing.Size(404, 55);
            this.architecture.TabIndex = 6;
            this.architecture.Text = "Enter CPU Arch:";
            // 
            // integratedGPU
            // 
            this.integratedGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integratedGPU.Location = new System.Drawing.Point(21, 676);
            this.integratedGPU.Name = "integratedGPU";
            this.integratedGPU.ReadOnly = true;
            this.integratedGPU.Size = new System.Drawing.Size(404, 55);
            this.integratedGPU.TabIndex = 7;
            this.integratedGPU.Text = "Integrated GPU?";
            // 
            // socket
            // 
            this.socket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.socket.Location = new System.Drawing.Point(21, 778);
            this.socket.Name = "socket";
            this.socket.ReadOnly = true;
            this.socket.Size = new System.Drawing.Size(404, 55);
            this.socket.TabIndex = 8;
            this.socket.Text = "Enter Socket: ";
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(543, 902);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(281, 62);
            this.submit.TabIndex = 24;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.Location = new System.Drawing.Point(144, 902);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(281, 62);
            this.mainMenu.TabIndex = 25;
            this.mainMenu.Text = "Main Menu";
            this.mainMenu.UseVisualStyleBackColor = true;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // coreCountEntry
            // 
            this.coreCountEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coreCountEntry.Location = new System.Drawing.Point(543, 308);
            this.coreCountEntry.Name = "coreCountEntry";
            this.coreCountEntry.Size = new System.Drawing.Size(340, 55);
            this.coreCountEntry.TabIndex = 26;
            // 
            // clockFreqEntry
            // 
            this.clockFreqEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockFreqEntry.Location = new System.Drawing.Point(543, 400);
            this.clockFreqEntry.Name = "clockFreqEntry";
            this.clockFreqEntry.Size = new System.Drawing.Size(340, 55);
            this.clockFreqEntry.TabIndex = 27;
            // 
            // maxTDPEntry
            // 
            this.maxTDPEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTDPEntry.Location = new System.Drawing.Point(543, 492);
            this.maxTDPEntry.Name = "maxTDPEntry";
            this.maxTDPEntry.Size = new System.Drawing.Size(340, 55);
            this.maxTDPEntry.TabIndex = 28;
            // 
            // cpuArchEntry
            // 
            this.cpuArchEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuArchEntry.Location = new System.Drawing.Point(543, 584);
            this.cpuArchEntry.Name = "cpuArchEntry";
            this.cpuArchEntry.Size = new System.Drawing.Size(340, 55);
            this.cpuArchEntry.TabIndex = 29;
            // 
            // intGpuEntry
            // 
            this.intGpuEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intGpuEntry.Location = new System.Drawing.Point(543, 676);
            this.intGpuEntry.Name = "intGpuEntry";
            this.intGpuEntry.Size = new System.Drawing.Size(340, 55);
            this.intGpuEntry.TabIndex = 30;
            this.intGpuEntry.Text = "Enter True / False";
            // 
            // socketEntry
            // 
            this.socketEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.socketEntry.Location = new System.Drawing.Point(543, 778);
            this.socketEntry.Name = "socketEntry";
            this.socketEntry.Size = new System.Drawing.Size(340, 55);
            this.socketEntry.TabIndex = 31;
            // 
            // pfScoreEntry
            // 
            this.pfScoreEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pfScoreEntry.Location = new System.Drawing.Point(543, 226);
            this.pfScoreEntry.Name = "pfScoreEntry";
            this.pfScoreEntry.Size = new System.Drawing.Size(340, 55);
            this.pfScoreEntry.TabIndex = 55;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(21, 226);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(404, 55);
            this.textBox2.TabIndex = 54;
            this.textBox2.Text = "Enter PF Score";
            // 
            // cpuManufacturerEntry
            // 
            this.cpuManufacturerEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuManufacturerEntry.Location = new System.Drawing.Point(543, 141);
            this.cpuManufacturerEntry.Name = "cpuManufacturerEntry";
            this.cpuManufacturerEntry.Size = new System.Drawing.Size(340, 55);
            this.cpuManufacturerEntry.TabIndex = 53;
            // 
            // Manufacturer
            // 
            this.Manufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manufacturer.Location = new System.Drawing.Point(21, 141);
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.ReadOnly = true;
            this.Manufacturer.Size = new System.Drawing.Size(404, 55);
            this.Manufacturer.TabIndex = 52;
            this.Manufacturer.Text = "Enter Manufacturer:";
            // 
            // cpuNameEntry
            // 
            this.cpuNameEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuNameEntry.Location = new System.Drawing.Point(543, 60);
            this.cpuNameEntry.Name = "cpuNameEntry";
            this.cpuNameEntry.Size = new System.Drawing.Size(340, 55);
            this.cpuNameEntry.TabIndex = 51;
            // 
            // ramName
            // 
            this.ramName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramName.Location = new System.Drawing.Point(21, 60);
            this.ramName.Name = "ramName";
            this.ramName.ReadOnly = true;
            this.ramName.Size = new System.Drawing.Size(404, 55);
            this.ramName.TabIndex = 50;
            this.ramName.Text = "Enter Name: ";
            // 
            // AddCPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(912, 1004);
            this.Controls.Add(this.pfScoreEntry);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cpuManufacturerEntry);
            this.Controls.Add(this.Manufacturer);
            this.Controls.Add(this.cpuNameEntry);
            this.Controls.Add(this.ramName);
            this.Controls.Add(this.socketEntry);
            this.Controls.Add(this.intGpuEntry);
            this.Controls.Add(this.cpuArchEntry);
            this.Controls.Add(this.maxTDPEntry);
            this.Controls.Add(this.clockFreqEntry);
            this.Controls.Add(this.coreCountEntry);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.socket);
            this.Controls.Add(this.integratedGPU);
            this.Controls.Add(this.architecture);
            this.Controls.Add(this.maxTDP);
            this.Controls.Add(this.clockFrequency);
            this.Controls.Add(this.CoreCount);
            this.Name = "AddCPU";
            this.Text = "Add CPU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CoreCount;
        private System.Windows.Forms.TextBox clockFrequency;
        private System.Windows.Forms.TextBox maxTDP;
        private System.Windows.Forms.TextBox architecture;
        private System.Windows.Forms.TextBox integratedGPU;
        private System.Windows.Forms.TextBox socket;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button mainMenu;
        private System.Windows.Forms.TextBox coreCountEntry;
        private System.Windows.Forms.TextBox clockFreqEntry;
        private System.Windows.Forms.TextBox maxTDPEntry;
        private System.Windows.Forms.TextBox cpuArchEntry;
        private System.Windows.Forms.TextBox intGpuEntry;
        private System.Windows.Forms.TextBox socketEntry;
        private System.Windows.Forms.TextBox pfScoreEntry;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox cpuManufacturerEntry;
        private System.Windows.Forms.TextBox Manufacturer;
        private System.Windows.Forms.TextBox cpuNameEntry;
        private System.Windows.Forms.TextBox ramName;
    }
}