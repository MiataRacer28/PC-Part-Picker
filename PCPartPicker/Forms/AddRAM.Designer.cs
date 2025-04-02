namespace PCPartPicker.Forms
{
    partial class AddRAM
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
            this.capacityEntry = new System.Windows.Forms.TextBox();
            this.capacity = new System.Windows.Forms.TextBox();
            this.memoryType = new System.Windows.Forms.TextBox();
            this.memFreq = new System.Windows.Forms.TextBox();
            this.latency = new System.Windows.Forms.TextBox();
            this.voltage = new System.Windows.Forms.TextBox();
            this.errorCorrecting = new System.Windows.Forms.TextBox();
            this.memTypeEntry = new System.Windows.Forms.TextBox();
            this.memFreqEntry = new System.Windows.Forms.TextBox();
            this.latencyEntry = new System.Windows.Forms.TextBox();
            this.voltageEntry = new System.Windows.Forms.TextBox();
            this.eccEntry = new System.Windows.Forms.TextBox();
            this.mainMenu = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // capacityEntry
            // 
            this.capacityEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacityEntry.Location = new System.Drawing.Point(528, 87);
            this.capacityEntry.Name = "capacityEntry";
            this.capacityEntry.Size = new System.Drawing.Size(340, 55);
            this.capacityEntry.TabIndex = 29;
            this.capacityEntry.Text = "Enter Text";
            this.capacityEntry.TextChanged += new System.EventHandler(this.capacityEntry_TextChanged);
            // 
            // capacity
            // 
            this.capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacity.Location = new System.Drawing.Point(42, 87);
            this.capacity.Name = "capacity";
            this.capacity.ReadOnly = true;
            this.capacity.Size = new System.Drawing.Size(404, 55);
            this.capacity.TabIndex = 28;
            this.capacity.Text = "Enter Capacity: ";
            // 
            // memoryType
            // 
            this.memoryType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryType.Location = new System.Drawing.Point(42, 179);
            this.memoryType.Name = "memoryType";
            this.memoryType.ReadOnly = true;
            this.memoryType.Size = new System.Drawing.Size(404, 55);
            this.memoryType.TabIndex = 30;
            this.memoryType.Text = "Enter Mem Type: ";
            // 
            // memFreq
            // 
            this.memFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memFreq.Location = new System.Drawing.Point(42, 271);
            this.memFreq.Name = "memFreq";
            this.memFreq.ReadOnly = true;
            this.memFreq.Size = new System.Drawing.Size(404, 55);
            this.memFreq.TabIndex = 31;
            this.memFreq.Text = "Enter Mem Freq: ";
            // 
            // latency
            // 
            this.latency.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latency.Location = new System.Drawing.Point(42, 367);
            this.latency.Name = "latency";
            this.latency.ReadOnly = true;
            this.latency.Size = new System.Drawing.Size(404, 55);
            this.latency.TabIndex = 32;
            this.latency.Text = "Enter Latency: ";
            // 
            // voltage
            // 
            this.voltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltage.Location = new System.Drawing.Point(42, 463);
            this.voltage.Name = "voltage";
            this.voltage.ReadOnly = true;
            this.voltage.Size = new System.Drawing.Size(404, 55);
            this.voltage.TabIndex = 33;
            this.voltage.Text = "Enter Voltage: ";
            // 
            // errorCorrecting
            // 
            this.errorCorrecting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorCorrecting.Location = new System.Drawing.Point(42, 565);
            this.errorCorrecting.Name = "errorCorrecting";
            this.errorCorrecting.ReadOnly = true;
            this.errorCorrecting.Size = new System.Drawing.Size(404, 55);
            this.errorCorrecting.TabIndex = 34;
            this.errorCorrecting.Text = "Error Correcting? ";
            // 
            // memTypeEntry
            // 
            this.memTypeEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memTypeEntry.Location = new System.Drawing.Point(528, 179);
            this.memTypeEntry.Name = "memTypeEntry";
            this.memTypeEntry.Size = new System.Drawing.Size(340, 55);
            this.memTypeEntry.TabIndex = 35;
            this.memTypeEntry.Text = "Enter Text";
            // 
            // memFreqEntry
            // 
            this.memFreqEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memFreqEntry.Location = new System.Drawing.Point(528, 271);
            this.memFreqEntry.Name = "memFreqEntry";
            this.memFreqEntry.Size = new System.Drawing.Size(340, 55);
            this.memFreqEntry.TabIndex = 36;
            this.memFreqEntry.Text = "Enter Text";
            // 
            // latencyEntry
            // 
            this.latencyEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latencyEntry.Location = new System.Drawing.Point(528, 367);
            this.latencyEntry.Name = "latencyEntry";
            this.latencyEntry.Size = new System.Drawing.Size(340, 55);
            this.latencyEntry.TabIndex = 37;
            this.latencyEntry.Text = "Enter Text";
            // 
            // voltageEntry
            // 
            this.voltageEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltageEntry.Location = new System.Drawing.Point(528, 463);
            this.voltageEntry.Name = "voltageEntry";
            this.voltageEntry.Size = new System.Drawing.Size(340, 55);
            this.voltageEntry.TabIndex = 38;
            this.voltageEntry.Text = "Enter Text";
            // 
            // eccEntry
            // 
            this.eccEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eccEntry.Location = new System.Drawing.Point(528, 565);
            this.eccEntry.Name = "eccEntry";
            this.eccEntry.Size = new System.Drawing.Size(340, 55);
            this.eccEntry.TabIndex = 39;
            this.eccEntry.Text = "Enter Yes / No";
            // 
            // mainMenu
            // 
            this.mainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.Location = new System.Drawing.Point(165, 865);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(281, 62);
            this.mainMenu.TabIndex = 41;
            this.mainMenu.Text = "Main Menu";
            this.mainMenu.UseVisualStyleBackColor = true;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(528, 865);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(281, 62);
            this.submit.TabIndex = 40;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // AddRAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(912, 1004);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.eccEntry);
            this.Controls.Add(this.voltageEntry);
            this.Controls.Add(this.latencyEntry);
            this.Controls.Add(this.memFreqEntry);
            this.Controls.Add(this.memTypeEntry);
            this.Controls.Add(this.errorCorrecting);
            this.Controls.Add(this.voltage);
            this.Controls.Add(this.latency);
            this.Controls.Add(this.memFreq);
            this.Controls.Add(this.memoryType);
            this.Controls.Add(this.capacityEntry);
            this.Controls.Add(this.capacity);
            this.Name = "AddRAM";
            this.Text = "Add RAM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox capacityEntry;
        private System.Windows.Forms.TextBox capacity;
        private System.Windows.Forms.TextBox memoryType;
        private System.Windows.Forms.TextBox memFreq;
        private System.Windows.Forms.TextBox latency;
        private System.Windows.Forms.TextBox voltage;
        private System.Windows.Forms.TextBox errorCorrecting;
        private System.Windows.Forms.TextBox memTypeEntry;
        private System.Windows.Forms.TextBox memFreqEntry;
        private System.Windows.Forms.TextBox latencyEntry;
        private System.Windows.Forms.TextBox voltageEntry;
        private System.Windows.Forms.TextBox eccEntry;
        private System.Windows.Forms.Button mainMenu;
        private System.Windows.Forms.Button submit;
    }
}