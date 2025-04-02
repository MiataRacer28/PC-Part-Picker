namespace PCPartPicker
{
    partial class DatabaseScreen
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
            this.addPart = new System.Windows.Forms.Button();
            this.removePart = new System.Windows.Forms.Button();
            this.mainMenuReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addPart
            // 
            this.addPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPart.Location = new System.Drawing.Point(312, 156);
            this.addPart.Name = "addPart";
            this.addPart.Size = new System.Drawing.Size(329, 121);
            this.addPart.TabIndex = 0;
            this.addPart.Text = "Add Part";
            this.addPart.UseVisualStyleBackColor = true;
            this.addPart.Click += new System.EventHandler(this.AddPart_click);
            // 
            // removePart
            // 
            this.removePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removePart.Location = new System.Drawing.Point(312, 405);
            this.removePart.Name = "removePart";
            this.removePart.Size = new System.Drawing.Size(329, 121);
            this.removePart.TabIndex = 1;
            this.removePart.Text = "Remove Part";
            this.removePart.UseVisualStyleBackColor = true;
            // 
            // mainMenuReturn
            // 
            this.mainMenuReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuReturn.Location = new System.Drawing.Point(226, 803);
            this.mainMenuReturn.Name = "mainMenuReturn";
            this.mainMenuReturn.Size = new System.Drawing.Size(500, 88);
            this.mainMenuReturn.TabIndex = 2;
            this.mainMenuReturn.Text = "Main Menu";
            this.mainMenuReturn.UseVisualStyleBackColor = true;
            this.mainMenuReturn.Click += new System.EventHandler(this.MainMenuReturn_Click);
            // 
            // DatabaseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(912, 1004);
            this.Controls.Add(this.mainMenuReturn);
            this.Controls.Add(this.removePart);
            this.Controls.Add(this.addPart);
            this.Name = "DatabaseScreen";
            this.Text = "Database Screen";
            this.Load += new System.EventHandler(this.DatabaseScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addPart;
        private System.Windows.Forms.Button removePart;
        private System.Windows.Forms.Button mainMenuReturn;
    }
}