namespace PCPartPicker
{
    partial class PartToAdd
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
            this.addCPU = new System.Windows.Forms.Button();
            this.addGPU = new System.Windows.Forms.Button();
            this.addRAM = new System.Windows.Forms.Button();
            this.addMobo = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addCPU
            // 
            this.addCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCPU.Location = new System.Drawing.Point(263, 239);
            this.addCPU.Name = "addCPU";
            this.addCPU.Size = new System.Drawing.Size(329, 121);
            this.addCPU.TabIndex = 1;
            this.addCPU.Text = "Add CPU";
            this.addCPU.UseVisualStyleBackColor = true;
            this.addCPU.Click += new System.EventHandler(this.addCPU_Click);
            // 
            // addGPU
            // 
            this.addGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGPU.Location = new System.Drawing.Point(263, 427);
            this.addGPU.Name = "addGPU";
            this.addGPU.Size = new System.Drawing.Size(329, 121);
            this.addGPU.TabIndex = 2;
            this.addGPU.Text = "Add GPU";
            this.addGPU.UseVisualStyleBackColor = true;
            this.addGPU.Click += new System.EventHandler(this.addGPU_Click);
            // 
            // addRAM
            // 
            this.addRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRAM.Location = new System.Drawing.Point(263, 615);
            this.addRAM.Name = "addRAM";
            this.addRAM.Size = new System.Drawing.Size(329, 121);
            this.addRAM.TabIndex = 3;
            this.addRAM.Text = "Add RAM";
            this.addRAM.UseVisualStyleBackColor = true;
            this.addRAM.Click += new System.EventHandler(this.addRAM_Click);
            // 
            // addMobo
            // 
            this.addMobo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMobo.Location = new System.Drawing.Point(263, 57);
            this.addMobo.Name = "addMobo";
            this.addMobo.Size = new System.Drawing.Size(329, 121);
            this.addMobo.TabIndex = 4;
            this.addMobo.Text = "Add Mobo";
            this.addMobo.UseVisualStyleBackColor = true;
            this.addMobo.Click += new System.EventHandler(this.addMobo_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.Location = new System.Drawing.Point(291, 828);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(281, 62);
            this.mainMenu.TabIndex = 5;
            this.mainMenu.Text = "Main Menu";
            this.mainMenu.UseVisualStyleBackColor = true;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // PartToAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(862, 974);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.addMobo);
            this.Controls.Add(this.addRAM);
            this.Controls.Add(this.addGPU);
            this.Controls.Add(this.addCPU);
            this.Name = "PartToAdd";
            this.Text = "Part To Add";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addCPU;
        private System.Windows.Forms.Button addGPU;
        private System.Windows.Forms.Button addRAM;
        private System.Windows.Forms.Button addMobo;
        private System.Windows.Forms.Button mainMenu;
    }
}