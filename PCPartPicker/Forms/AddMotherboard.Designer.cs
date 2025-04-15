namespace PCPartPicker.Forms
{
    partial class AddMotherboard
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.formFactor = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Socket = new System.Windows.Forms.TextBox();
            this.Chipset = new System.Windows.Forms.TextBox();
            this.MemoryType = new System.Windows.Forms.TextBox();
            this.MaxMem = new System.Windows.Forms.TextBox();
            this.MaxMemSpeed = new System.Windows.Forms.TextBox();
            this.PCIeSlotN = new System.Windows.Forms.TextBox();
            this.MaxPCIeSlotType = new System.Windows.Forms.TextBox();
            this.PCIeVer = new System.Windows.Forms.TextBox();
            this.mainMenu = new System.Windows.Forms.Button();
            this.FormFactorEntry = new System.Windows.Forms.TextBox();
            this.SocketEntry = new System.Windows.Forms.TextBox();
            this.ChipsetEntry = new System.Windows.Forms.TextBox();
            this.MemTypeEntry = new System.Windows.Forms.TextBox();
            this.MaxMemEntry = new System.Windows.Forms.TextBox();
            this.maxMemSpeedEntry = new System.Windows.Forms.TextBox();
            this.PcieSlotNEntry = new System.Windows.Forms.TextBox();
            this.maxPCIeSlotTypeEntry = new System.Windows.Forms.TextBox();
            this.PCIeVersionEntry = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.pfScoreEntry = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.MoboManufacturerEntry = new System.Windows.Forms.TextBox();
            this.Manufacturer = new System.Windows.Forms.TextBox();
            this.moboNameEntry = new System.Windows.Forms.TextBox();
            this.moboName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // formFactor
            // 
            this.formFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formFactor.Location = new System.Drawing.Point(34, 240);
            this.formFactor.Name = "formFactor";
            this.formFactor.ReadOnly = true;
            this.formFactor.Size = new System.Drawing.Size(404, 55);
            this.formFactor.TabIndex = 2;
            this.formFactor.Text = "Enter Form Factor:";
            this.formFactor.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // Socket
            // 
            this.Socket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Socket.Location = new System.Drawing.Point(34, 316);
            this.Socket.Name = "Socket";
            this.Socket.ReadOnly = true;
            this.Socket.Size = new System.Drawing.Size(404, 55);
            this.Socket.TabIndex = 5;
            this.Socket.Text = "Enter Socket: ";
            this.Socket.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // Chipset
            // 
            this.Chipset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chipset.Location = new System.Drawing.Point(34, 396);
            this.Chipset.Name = "Chipset";
            this.Chipset.ReadOnly = true;
            this.Chipset.Size = new System.Drawing.Size(404, 55);
            this.Chipset.TabIndex = 6;
            this.Chipset.Text = "Enter Chipset: ";
            // 
            // MemoryType
            // 
            this.MemoryType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryType.Location = new System.Drawing.Point(34, 474);
            this.MemoryType.Name = "MemoryType";
            this.MemoryType.ReadOnly = true;
            this.MemoryType.Size = new System.Drawing.Size(404, 55);
            this.MemoryType.TabIndex = 7;
            this.MemoryType.Text = "Enter Memory Type:";
            // 
            // MaxMem
            // 
            this.MaxMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxMem.Location = new System.Drawing.Point(34, 554);
            this.MaxMem.Name = "MaxMem";
            this.MaxMem.ReadOnly = true;
            this.MaxMem.Size = new System.Drawing.Size(404, 55);
            this.MaxMem.TabIndex = 8;
            this.MaxMem.Text = "Enter Max Mem:";
            // 
            // MaxMemSpeed
            // 
            this.MaxMemSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxMemSpeed.Location = new System.Drawing.Point(34, 632);
            this.MaxMemSpeed.Name = "MaxMemSpeed";
            this.MaxMemSpeed.ReadOnly = true;
            this.MaxMemSpeed.Size = new System.Drawing.Size(404, 55);
            this.MaxMemSpeed.TabIndex = 9;
            this.MaxMemSpeed.Text = "Enter Max Mem SPD:";
            this.MaxMemSpeed.TextChanged += new System.EventHandler(this.MaxMemSpeedEntry_TextChanged);
            // 
            // PCIeSlotN
            // 
            this.PCIeSlotN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCIeSlotN.Location = new System.Drawing.Point(34, 702);
            this.PCIeSlotN.Name = "PCIeSlotN";
            this.PCIeSlotN.ReadOnly = true;
            this.PCIeSlotN.Size = new System.Drawing.Size(404, 55);
            this.PCIeSlotN.TabIndex = 10;
            this.PCIeSlotN.Text = "Enter PCIe Slots #: ";
            // 
            // MaxPCIeSlotType
            // 
            this.MaxPCIeSlotType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxPCIeSlotType.Location = new System.Drawing.Point(34, 780);
            this.MaxPCIeSlotType.Name = "MaxPCIeSlotType";
            this.MaxPCIeSlotType.ReadOnly = true;
            this.MaxPCIeSlotType.Size = new System.Drawing.Size(404, 55);
            this.MaxPCIeSlotType.TabIndex = 11;
            this.MaxPCIeSlotType.Text = "Enter Max PCIe Slot type: ";
            // 
            // PCIeVer
            // 
            this.PCIeVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCIeVer.Location = new System.Drawing.Point(34, 854);
            this.PCIeVer.Name = "PCIeVer";
            this.PCIeVer.ReadOnly = true;
            this.PCIeVer.Size = new System.Drawing.Size(404, 55);
            this.PCIeVer.TabIndex = 12;
            this.PCIeVer.Text = "Enter PCIe Version: ";
            // 
            // mainMenu
            // 
            this.mainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.Location = new System.Drawing.Point(157, 920);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(281, 62);
            this.mainMenu.TabIndex = 13;
            this.mainMenu.Text = "Main Menu";
            this.mainMenu.UseVisualStyleBackColor = true;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // FormFactorEntry
            // 
            this.FormFactorEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormFactorEntry.Location = new System.Drawing.Point(525, 240);
            this.FormFactorEntry.Name = "FormFactorEntry";
            this.FormFactorEntry.Size = new System.Drawing.Size(340, 55);
            this.FormFactorEntry.TabIndex = 14;
            this.FormFactorEntry.TextChanged += new System.EventHandler(this.textBox1_TextChanged_3);
            // 
            // SocketEntry
            // 
            this.SocketEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SocketEntry.Location = new System.Drawing.Point(525, 316);
            this.SocketEntry.Name = "SocketEntry";
            this.SocketEntry.Size = new System.Drawing.Size(340, 55);
            this.SocketEntry.TabIndex = 15;
            // 
            // ChipsetEntry
            // 
            this.ChipsetEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChipsetEntry.Location = new System.Drawing.Point(525, 396);
            this.ChipsetEntry.Name = "ChipsetEntry";
            this.ChipsetEntry.Size = new System.Drawing.Size(340, 55);
            this.ChipsetEntry.TabIndex = 16;
            // 
            // MemTypeEntry
            // 
            this.MemTypeEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemTypeEntry.Location = new System.Drawing.Point(525, 474);
            this.MemTypeEntry.Name = "MemTypeEntry";
            this.MemTypeEntry.Size = new System.Drawing.Size(340, 55);
            this.MemTypeEntry.TabIndex = 17;
            this.MemTypeEntry.TextChanged += new System.EventHandler(this.textBox1_TextChanged_4);
            // 
            // MaxMemEntry
            // 
            this.MaxMemEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxMemEntry.Location = new System.Drawing.Point(525, 554);
            this.MaxMemEntry.Name = "MaxMemEntry";
            this.MaxMemEntry.Size = new System.Drawing.Size(340, 55);
            this.MaxMemEntry.TabIndex = 18;
            // 
            // maxMemSpeedEntry
            // 
            this.maxMemSpeedEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxMemSpeedEntry.Location = new System.Drawing.Point(525, 632);
            this.maxMemSpeedEntry.Name = "maxMemSpeedEntry";
            this.maxMemSpeedEntry.Size = new System.Drawing.Size(340, 55);
            this.maxMemSpeedEntry.TabIndex = 19;
            // 
            // PcieSlotNEntry
            // 
            this.PcieSlotNEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PcieSlotNEntry.Location = new System.Drawing.Point(525, 702);
            this.PcieSlotNEntry.Name = "PcieSlotNEntry";
            this.PcieSlotNEntry.Size = new System.Drawing.Size(340, 55);
            this.PcieSlotNEntry.TabIndex = 20;
            // 
            // maxPCIeSlotTypeEntry
            // 
            this.maxPCIeSlotTypeEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxPCIeSlotTypeEntry.Location = new System.Drawing.Point(525, 780);
            this.maxPCIeSlotTypeEntry.Name = "maxPCIeSlotTypeEntry";
            this.maxPCIeSlotTypeEntry.Size = new System.Drawing.Size(340, 55);
            this.maxPCIeSlotTypeEntry.TabIndex = 21;
            // 
            // PCIeVersionEntry
            // 
            this.PCIeVersionEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCIeVersionEntry.Location = new System.Drawing.Point(525, 854);
            this.PCIeVersionEntry.Name = "PCIeVersionEntry";
            this.PCIeVersionEntry.Size = new System.Drawing.Size(340, 55);
            this.PCIeVersionEntry.TabIndex = 22;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(525, 920);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(281, 62);
            this.submit.TabIndex = 23;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.Submit);
            // 
            // pfScoreEntry
            // 
            this.pfScoreEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pfScoreEntry.Location = new System.Drawing.Point(525, 170);
            this.pfScoreEntry.Name = "pfScoreEntry";
            this.pfScoreEntry.Size = new System.Drawing.Size(340, 55);
            this.pfScoreEntry.TabIndex = 49;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(34, 170);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(404, 55);
            this.textBox2.TabIndex = 48;
            this.textBox2.Text = "Enter PF Score";
            // 
            // MoboManufacturerEntry
            // 
            this.MoboManufacturerEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoboManufacturerEntry.Location = new System.Drawing.Point(525, 98);
            this.MoboManufacturerEntry.Name = "MoboManufacturerEntry";
            this.MoboManufacturerEntry.Size = new System.Drawing.Size(340, 55);
            this.MoboManufacturerEntry.TabIndex = 47;
            // 
            // Manufacturer
            // 
            this.Manufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manufacturer.Location = new System.Drawing.Point(34, 98);
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.ReadOnly = true;
            this.Manufacturer.Size = new System.Drawing.Size(404, 55);
            this.Manufacturer.TabIndex = 46;
            this.Manufacturer.Text = "Enter Manufacturer:";
            // 
            // moboNameEntry
            // 
            this.moboNameEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moboNameEntry.Location = new System.Drawing.Point(525, 24);
            this.moboNameEntry.Name = "moboNameEntry";
            this.moboNameEntry.Size = new System.Drawing.Size(340, 55);
            this.moboNameEntry.TabIndex = 45;
            // 
            // moboName
            // 
            this.moboName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moboName.Location = new System.Drawing.Point(34, 24);
            this.moboName.Name = "moboName";
            this.moboName.ReadOnly = true;
            this.moboName.Size = new System.Drawing.Size(404, 55);
            this.moboName.TabIndex = 44;
            this.moboName.Text = "Enter Name:";
            // 
            // AddMotherboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(912, 1004);
            this.Controls.Add(this.pfScoreEntry);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.MoboManufacturerEntry);
            this.Controls.Add(this.Manufacturer);
            this.Controls.Add(this.moboNameEntry);
            this.Controls.Add(this.moboName);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.PCIeVersionEntry);
            this.Controls.Add(this.maxPCIeSlotTypeEntry);
            this.Controls.Add(this.PcieSlotNEntry);
            this.Controls.Add(this.maxMemSpeedEntry);
            this.Controls.Add(this.MaxMemEntry);
            this.Controls.Add(this.MemTypeEntry);
            this.Controls.Add(this.ChipsetEntry);
            this.Controls.Add(this.SocketEntry);
            this.Controls.Add(this.FormFactorEntry);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.PCIeVer);
            this.Controls.Add(this.MaxPCIeSlotType);
            this.Controls.Add(this.PCIeSlotN);
            this.Controls.Add(this.MaxMemSpeed);
            this.Controls.Add(this.MaxMem);
            this.Controls.Add(this.MemoryType);
            this.Controls.Add(this.Chipset);
            this.Controls.Add(this.Socket);
            this.Controls.Add(this.formFactor);
            this.Name = "AddMotherboard";
            this.Text = "Add Motherboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox formFactor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.TextBox Socket;
        private System.Windows.Forms.TextBox Chipset;
        private System.Windows.Forms.TextBox MemoryType;
        private System.Windows.Forms.TextBox MaxMem;
        private System.Windows.Forms.TextBox MaxMemSpeed;
        private System.Windows.Forms.TextBox PCIeSlotN;
        private System.Windows.Forms.TextBox MaxPCIeSlotType;
        private System.Windows.Forms.TextBox PCIeVer;
        private System.Windows.Forms.Button mainMenu;
        private System.Windows.Forms.TextBox FormFactorEntry;
        private System.Windows.Forms.TextBox SocketEntry;
        private System.Windows.Forms.TextBox ChipsetEntry;
        private System.Windows.Forms.TextBox MemTypeEntry;
        private System.Windows.Forms.TextBox MaxMemEntry;
        private System.Windows.Forms.TextBox maxMemSpeedEntry;
        private System.Windows.Forms.TextBox PcieSlotNEntry;
        private System.Windows.Forms.TextBox maxPCIeSlotTypeEntry;
        private System.Windows.Forms.TextBox PCIeVersionEntry;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox pfScoreEntry;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox MoboManufacturerEntry;
        private System.Windows.Forms.TextBox Manufacturer;
        private System.Windows.Forms.TextBox moboNameEntry;
        private System.Windows.Forms.TextBox moboName;
    }
}