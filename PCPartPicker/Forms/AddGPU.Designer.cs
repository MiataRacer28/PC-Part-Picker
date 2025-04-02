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
            this.SuspendLayout();
            // 
            // CoreCount
            // 
            this.CoreCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoreCount.Location = new System.Drawing.Point(24, 57);
            this.CoreCount.Name = "CoreCount";
            this.CoreCount.ReadOnly = true;
            this.CoreCount.Size = new System.Drawing.Size(404, 55);
            this.CoreCount.TabIndex = 4;
            this.CoreCount.Text = "Enter Core Count:";
            // 
            // baseClock
            // 
            this.baseClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseClock.Location = new System.Drawing.Point(24, 153);
            this.baseClock.Name = "baseClock";
            this.baseClock.ReadOnly = true;
            this.baseClock.Size = new System.Drawing.Size(404, 55);
            this.baseClock.TabIndex = 5;
            this.baseClock.Text = "Enter Base Clock: ";
            // 
            // maxClock
            // 
            this.maxClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxClock.Location = new System.Drawing.Point(24, 253);
            this.maxClock.Name = "maxClock";
            this.maxClock.ReadOnly = true;
            this.maxClock.Size = new System.Drawing.Size(404, 55);
            this.maxClock.TabIndex = 6;
            this.maxClock.Text = "Enter Max Clock: ";
            // 
            // architecture
            // 
            this.architecture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.architecture.Location = new System.Drawing.Point(24, 353);
            this.architecture.Name = "architecture";
            this.architecture.ReadOnly = true;
            this.architecture.Size = new System.Drawing.Size(404, 55);
            this.architecture.TabIndex = 7;
            this.architecture.Text = "Enter GPU Arch: ";
            // 
            // vram
            // 
            this.vram.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vram.Location = new System.Drawing.Point(24, 447);
            this.vram.Name = "vram";
            this.vram.ReadOnly = true;
            this.vram.Size = new System.Drawing.Size(404, 55);
            this.vram.TabIndex = 8;
            this.vram.Text = "Enter GPU VRAM:";
            // 
            // memType
            // 
            this.memType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memType.Location = new System.Drawing.Point(24, 545);
            this.memType.Name = "memType";
            this.memType.ReadOnly = true;
            this.memType.Size = new System.Drawing.Size(404, 55);
            this.memType.TabIndex = 9;
            this.memType.Text = "Enter Mem Type: ";
            // 
            // maxTDP
            // 
            this.maxTDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTDP.Location = new System.Drawing.Point(24, 635);
            this.maxTDP.Name = "maxTDP";
            this.maxTDP.ReadOnly = true;
            this.maxTDP.Size = new System.Drawing.Size(404, 55);
            this.maxTDP.TabIndex = 10;
            this.maxTDP.Text = "Enter Max TDP: ";
            // 
            // raytracing
            // 
            this.raytracing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raytracing.Location = new System.Drawing.Point(24, 731);
            this.raytracing.Name = "raytracing";
            this.raytracing.ReadOnly = true;
            this.raytracing.Size = new System.Drawing.Size(404, 55);
            this.raytracing.TabIndex = 11;
            this.raytracing.Text = "Raytracing Support? ";
            // 
            // graphicsAPI
            // 
            this.graphicsAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphicsAPI.Location = new System.Drawing.Point(24, 829);
            this.graphicsAPI.Name = "graphicsAPI";
            this.graphicsAPI.ReadOnly = true;
            this.graphicsAPI.Size = new System.Drawing.Size(404, 55);
            this.graphicsAPI.TabIndex = 12;
            this.graphicsAPI.Text = "Maximum-GFX-API: ";
            // 
            // coreCountEntry
            // 
            this.coreCountEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coreCountEntry.Location = new System.Drawing.Point(510, 57);
            this.coreCountEntry.Name = "coreCountEntry";
            this.coreCountEntry.Size = new System.Drawing.Size(340, 55);
            this.coreCountEntry.TabIndex = 27;
            this.coreCountEntry.Text = "Enter Text";
            // 
            // baseClockEntry
            // 
            this.baseClockEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseClockEntry.Location = new System.Drawing.Point(510, 153);
            this.baseClockEntry.Name = "baseClockEntry";
            this.baseClockEntry.Size = new System.Drawing.Size(340, 55);
            this.baseClockEntry.TabIndex = 28;
            this.baseClockEntry.Text = "Enter Text";
            // 
            // maxClockEntry
            // 
            this.maxClockEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxClockEntry.Location = new System.Drawing.Point(510, 253);
            this.maxClockEntry.Name = "maxClockEntry";
            this.maxClockEntry.Size = new System.Drawing.Size(340, 55);
            this.maxClockEntry.TabIndex = 29;
            this.maxClockEntry.Text = "Enter Text";
            // 
            // gpuArchEntry
            // 
            this.gpuArchEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuArchEntry.Location = new System.Drawing.Point(510, 353);
            this.gpuArchEntry.Name = "gpuArchEntry";
            this.gpuArchEntry.Size = new System.Drawing.Size(340, 55);
            this.gpuArchEntry.TabIndex = 30;
            this.gpuArchEntry.Text = "Enter Text";
            // 
            // vramEntry
            // 
            this.vramEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vramEntry.Location = new System.Drawing.Point(510, 447);
            this.vramEntry.Name = "vramEntry";
            this.vramEntry.Size = new System.Drawing.Size(340, 55);
            this.vramEntry.TabIndex = 31;
            this.vramEntry.Text = "Enter Text";
            // 
            // memTypeEntry
            // 
            this.memTypeEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memTypeEntry.Location = new System.Drawing.Point(510, 545);
            this.memTypeEntry.Name = "memTypeEntry";
            this.memTypeEntry.Size = new System.Drawing.Size(340, 55);
            this.memTypeEntry.TabIndex = 32;
            this.memTypeEntry.Text = "Enter Text";
            // 
            // maxTDPEntry
            // 
            this.maxTDPEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTDPEntry.Location = new System.Drawing.Point(510, 635);
            this.maxTDPEntry.Name = "maxTDPEntry";
            this.maxTDPEntry.Size = new System.Drawing.Size(340, 55);
            this.maxTDPEntry.TabIndex = 33;
            this.maxTDPEntry.Text = "Enter Text";
            // 
            // raytracingEntry
            // 
            this.raytracingEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raytracingEntry.Location = new System.Drawing.Point(510, 731);
            this.raytracingEntry.Name = "raytracingEntry";
            this.raytracingEntry.Size = new System.Drawing.Size(340, 55);
            this.raytracingEntry.TabIndex = 34;
            this.raytracingEntry.Text = "Enter Yes / No";
            // 
            // gfxAPIEntry
            // 
            this.gfxAPIEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gfxAPIEntry.Location = new System.Drawing.Point(510, 829);
            this.gfxAPIEntry.Name = "gfxAPIEntry";
            this.gfxAPIEntry.Size = new System.Drawing.Size(340, 55);
            this.gfxAPIEntry.TabIndex = 35;
            this.gfxAPIEntry.Text = "Enter Text";
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
            // 
            // AddGPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(912, 1004);
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
    }
}