namespace PCPartPicker.Forms
{
    partial class AddGPU
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
            this.baseClock = new System.Windows.Forms.TextBox();
            this.maxClock = new System.Windows.Forms.TextBox();
            this.architecture = new System.Windows.Forms.TextBox();
            this.vram = new System.Windows.Forms.TextBox();
            this.memType = new System.Windows.Forms.TextBox();
            this.maxTDP = new System.Windows.Forms.TextBox();
            this.raytracing = new System.Windows.Forms.TextBox();
            this.graphicsAPI = new System.Windows.Forms.TextBox();
            this.coreCountEntry = new System.Windows.Forms.TextBox();
            this.baseClockEntry = new System.Windows.Forms.TextBox();
            this.maxClockEntry = new System.Windows.Forms.TextBox();
            this.gpuArchEntry = new System.Windows.Forms.TextBox();
            this.vramEntry = new System.Windows.Forms.TextBox();
            this.memTypeEntry = new System.Windows.Forms.TextBox();
            this.maxTDPEntry = new System.Windows.Forms.TextBox();
            this.raytracingEntry = new System.Windows.Forms.TextBox();
            this.gfxAPIEntry = new System.Windows.Forms.TextBox();
            this.mainMenu = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.gpuName = new System.Windows.Forms.TextBox();
            this.gpuNameEntry = new System.Windows.Forms.TextBox();
            this.gpuManufacturerEntry = new System.Windows.Forms.TextBox();
            this.Manufacturer = new System.Windows.Forms.TextBox();
            this.pfScoreEntry = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CoreCount
            // 
            this.CoreCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoreCount.Location = new System.Drawing.Point(24, 251);
            this.CoreCount.Name = "CoreCount";
            this.CoreCount.ReadOnly = true;
            this.CoreCount.Size = new System.Drawing.Size(404, 55);
            this.CoreCount.TabIndex = 4;
            this.CoreCount.Text = "Enter Core Count:";
            // 
            // baseClock
            // 
            this.baseClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseClock.Location = new System.Drawing.Point(24, 321);
            this.baseClock.Name = "baseClock";
            this.baseClock.ReadOnly = true;
            this.baseClock.Size = new System.Drawing.Size(404, 55);
            this.baseClock.TabIndex = 5;
            this.baseClock.Text = "Enter Base Clock: ";
            // 
            // maxClock
            // 
            this.maxClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxClock.Location = new System.Drawing.Point(24, 391);
            this.maxClock.Name = "maxClock";
            this.maxClock.ReadOnly = true;
            this.maxClock.Size = new System.Drawing.Size(404, 55);
            this.maxClock.TabIndex = 6;
            this.maxClock.Text = "Enter Max Clock: ";
            // 
            // architecture
            // 
            this.architecture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.architecture.Location = new System.Drawing.Point(24, 463);
            this.architecture.Name = "architecture";
            this.architecture.ReadOnly = true;
            this.architecture.Size = new System.Drawing.Size(404, 55);
            this.architecture.TabIndex = 7;
            this.architecture.Text = "Enter GPU Arch: ";
            // 
            // vram
            // 
            this.vram.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vram.Location = new System.Drawing.Point(24, 533);
            this.vram.Name = "vram";
            this.vram.ReadOnly = true;
            this.vram.Size = new System.Drawing.Size(404, 55);
            this.vram.TabIndex = 8;
            this.vram.Text = "Enter GPU VRAM:";
            // 
            // memType
            // 
            this.memType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memType.Location = new System.Drawing.Point(24, 603);
            this.memType.Name = "memType";
            this.memType.ReadOnly = true;
            this.memType.Size = new System.Drawing.Size(404, 55);
            this.memType.TabIndex = 9;
            this.memType.Text = "Enter Mem Type: ";
            // 
            // maxTDP
            // 
            this.maxTDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTDP.Location = new System.Drawing.Point(24, 673);
            this.maxTDP.Name = "maxTDP";
            this.maxTDP.ReadOnly = true;
            this.maxTDP.Size = new System.Drawing.Size(404, 55);
            this.maxTDP.TabIndex = 10;
            this.maxTDP.Text = "Enter Max TDP: ";
            // 
            // raytracing
            // 
            this.raytracing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raytracing.Location = new System.Drawing.Point(24, 743);
            this.raytracing.Name = "raytracing";
            this.raytracing.ReadOnly = true;
            this.raytracing.Size = new System.Drawing.Size(404, 55);
            this.raytracing.TabIndex = 11;
            this.raytracing.Text = "Raytracing Support? ";
            // 
            // graphicsAPI
            // 
            this.graphicsAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphicsAPI.Location = new System.Drawing.Point(24, 815);
            this.graphicsAPI.Name = "graphicsAPI";
            this.graphicsAPI.ReadOnly = true;
            this.graphicsAPI.Size = new System.Drawing.Size(404, 55);
            this.graphicsAPI.TabIndex = 12;
            this.graphicsAPI.Text = "Maximum-GFX-API: ";
            // 
            // coreCountEntry
            // 
            this.coreCountEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coreCountEntry.Location = new System.Drawing.Point(510, 251);
            this.coreCountEntry.Name = "coreCountEntry";
            this.coreCountEntry.Size = new System.Drawing.Size(340, 55);
            this.coreCountEntry.TabIndex = 27;
            this.coreCountEntry.TextChanged += new System.EventHandler(this.coreCountEntry_TextChanged);
            // 
            // baseClockEntry
            // 
            this.baseClockEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseClockEntry.Location = new System.Drawing.Point(510, 321);
            this.baseClockEntry.Name = "baseClockEntry";
            this.baseClockEntry.Size = new System.Drawing.Size(340, 55);
            this.baseClockEntry.TabIndex = 28;
            this.baseClockEntry.TextChanged += new System.EventHandler(this.baseClockEntry_TextChanged);
            // 
            // maxClockEntry
            // 
            this.maxClockEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxClockEntry.Location = new System.Drawing.Point(510, 391);
            this.maxClockEntry.Name = "maxClockEntry";
            this.maxClockEntry.Size = new System.Drawing.Size(340, 55);
            this.maxClockEntry.TabIndex = 29;
            this.maxClockEntry.TextChanged += new System.EventHandler(this.maxClockEntry_TextChanged);
            // 
            // gpuArchEntry
            // 
            this.gpuArchEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuArchEntry.Location = new System.Drawing.Point(510, 463);
            this.gpuArchEntry.Name = "gpuArchEntry";
            this.gpuArchEntry.Size = new System.Drawing.Size(340, 55);
            this.gpuArchEntry.TabIndex = 30;
            this.gpuArchEntry.TextChanged += new System.EventHandler(this.gpuArchEntry_TextChanged);
            // 
            // vramEntry
            // 
            this.vramEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vramEntry.Location = new System.Drawing.Point(510, 533);
            this.vramEntry.Name = "vramEntry";
            this.vramEntry.Size = new System.Drawing.Size(340, 55);
            this.vramEntry.TabIndex = 31;
            this.vramEntry.TextChanged += new System.EventHandler(this.vramEntry_TextChanged);
            // 
            // memTypeEntry
            // 
            this.memTypeEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memTypeEntry.Location = new System.Drawing.Point(510, 603);
            this.memTypeEntry.Name = "memTypeEntry";
            this.memTypeEntry.Size = new System.Drawing.Size(340, 55);
            this.memTypeEntry.TabIndex = 32;
            this.memTypeEntry.TextChanged += new System.EventHandler(this.memTypeEntry_TextChanged);
            // 
            // maxTDPEntry
            // 
            this.maxTDPEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTDPEntry.Location = new System.Drawing.Point(510, 673);
            this.maxTDPEntry.Name = "maxTDPEntry";
            this.maxTDPEntry.Size = new System.Drawing.Size(340, 55);
            this.maxTDPEntry.TabIndex = 33;
            this.maxTDPEntry.TextChanged += new System.EventHandler(this.maxTDPEntry_TextChanged);
            // 
            // raytracingEntry
            // 
            this.raytracingEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raytracingEntry.Location = new System.Drawing.Point(510, 743);
            this.raytracingEntry.Name = "raytracingEntry";
            this.raytracingEntry.Size = new System.Drawing.Size(340, 55);
            this.raytracingEntry.TabIndex = 34;
            this.raytracingEntry.Text = "Enter True / False";
            this.raytracingEntry.TextChanged += new System.EventHandler(this.raytracingEntry_TextChanged);
            // 
            // gfxAPIEntry
            // 
            this.gfxAPIEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gfxAPIEntry.Location = new System.Drawing.Point(510, 815);
            this.gfxAPIEntry.Name = "gfxAPIEntry";
            this.gfxAPIEntry.Size = new System.Drawing.Size(340, 55);
            this.gfxAPIEntry.TabIndex = 35;
            this.gfxAPIEntry.TextChanged += new System.EventHandler(this.gfxAPIEntry_TextChanged);
            // 
            // mainMenu
            // 
            this.mainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.Location = new System.Drawing.Point(147, 917);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(281, 62);
            this.mainMenu.TabIndex = 37;
            this.mainMenu.Text = "Main Menu";
            this.mainMenu.UseVisualStyleBackColor = true;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(510, 917);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(281, 62);
            this.submit.TabIndex = 36;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // gpuName
            // 
            this.gpuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuName.Location = new System.Drawing.Point(24, 35);
            this.gpuName.Name = "gpuName";
            this.gpuName.ReadOnly = true;
            this.gpuName.Size = new System.Drawing.Size(404, 55);
            this.gpuName.TabIndex = 38;
            this.gpuName.Text = "Enter GPU Name:";
            // 
            // gpuNameEntry
            // 
            this.gpuNameEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuNameEntry.Location = new System.Drawing.Point(510, 35);
            this.gpuNameEntry.Name = "gpuNameEntry";
            this.gpuNameEntry.Size = new System.Drawing.Size(340, 55);
            this.gpuNameEntry.TabIndex = 39;
            this.gpuNameEntry.TextChanged += new System.EventHandler(this.gpuNameEntry_TextChanged);
            // 
            // gpuManufacturerEntry
            // 
            this.gpuManufacturerEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuManufacturerEntry.Location = new System.Drawing.Point(510, 109);
            this.gpuManufacturerEntry.Name = "gpuManufacturerEntry";
            this.gpuManufacturerEntry.Size = new System.Drawing.Size(340, 55);
            this.gpuManufacturerEntry.TabIndex = 41;
            this.gpuManufacturerEntry.TextChanged += new System.EventHandler(this.gpuManufacturerEntry_TextChanged);
            // 
            // Manufacturer
            // 
            this.Manufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manufacturer.Location = new System.Drawing.Point(24, 109);
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.ReadOnly = true;
            this.Manufacturer.Size = new System.Drawing.Size(404, 55);
            this.Manufacturer.TabIndex = 40;
            this.Manufacturer.Text = "Enter Manufacturer:";
            // 
            // pfScoreEntry
            // 
            this.pfScoreEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pfScoreEntry.Location = new System.Drawing.Point(510, 181);
            this.pfScoreEntry.Name = "pfScoreEntry";
            this.pfScoreEntry.Size = new System.Drawing.Size(340, 55);
            this.pfScoreEntry.TabIndex = 43;
            this.pfScoreEntry.TextChanged += new System.EventHandler(this.pfScoreEntry_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(24, 181);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(404, 55);
            this.textBox2.TabIndex = 42;
            this.textBox2.Text = "Enter PF Score";
            // 
            // AddGPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(912, 1004);
            this.Controls.Add(this.pfScoreEntry);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.gpuManufacturerEntry);
            this.Controls.Add(this.Manufacturer);
            this.Controls.Add(this.gpuNameEntry);
            this.Controls.Add(this.gpuName);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.gfxAPIEntry);
            this.Controls.Add(this.raytracingEntry);
            this.Controls.Add(this.maxTDPEntry);
            this.Controls.Add(this.memTypeEntry);
            this.Controls.Add(this.vramEntry);
            this.Controls.Add(this.gpuArchEntry);
            this.Controls.Add(this.maxClockEntry);
            this.Controls.Add(this.baseClockEntry);
            this.Controls.Add(this.coreCountEntry);
            this.Controls.Add(this.graphicsAPI);
            this.Controls.Add(this.raytracing);
            this.Controls.Add(this.maxTDP);
            this.Controls.Add(this.memType);
            this.Controls.Add(this.vram);
            this.Controls.Add(this.architecture);
            this.Controls.Add(this.maxClock);
            this.Controls.Add(this.baseClock);
            this.Controls.Add(this.CoreCount);
            this.Name = "AddGPU";
            this.Text = "Add GPU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CoreCount;
        private System.Windows.Forms.TextBox baseClock;
        private System.Windows.Forms.TextBox maxClock;
        private System.Windows.Forms.TextBox architecture;
        private System.Windows.Forms.TextBox vram;
        private System.Windows.Forms.TextBox memType;
        private System.Windows.Forms.TextBox maxTDP;
        private System.Windows.Forms.TextBox raytracing;
        private System.Windows.Forms.TextBox graphicsAPI;
        private System.Windows.Forms.TextBox coreCountEntry;
        private System.Windows.Forms.TextBox baseClockEntry;
        private System.Windows.Forms.TextBox maxClockEntry;
        private System.Windows.Forms.TextBox gpuArchEntry;
        private System.Windows.Forms.TextBox vramEntry;
        private System.Windows.Forms.TextBox memTypeEntry;
        private System.Windows.Forms.TextBox maxTDPEntry;
        private System.Windows.Forms.TextBox raytracingEntry;
        private System.Windows.Forms.TextBox gfxAPIEntry;
        private System.Windows.Forms.Button mainMenu;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox gpuName;
        private System.Windows.Forms.TextBox gpuNameEntry;
        private System.Windows.Forms.TextBox gpuManufacturerEntry;
        private System.Windows.Forms.TextBox Manufacturer;
        private System.Windows.Forms.TextBox pfScoreEntry;
        private System.Windows.Forms.TextBox textBox2;
    }
}