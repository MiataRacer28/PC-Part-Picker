namespace PCPartPicker.Models
{
    partial class RemovePart
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
            this.PartsListTotal = new System.Windows.Forms.ListBox();
            this.mainMenu = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PartsListTotal
            // 
            this.PartsListTotal.FormattingEnabled = true;
            this.PartsListTotal.ItemHeight = 29;
            this.PartsListTotal.Location = new System.Drawing.Point(84, 117);
            this.PartsListTotal.Name = "PartsListTotal";
            this.PartsListTotal.Size = new System.Drawing.Size(644, 323);
            this.PartsListTotal.TabIndex = 0;
            this.PartsListTotal.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // mainMenu
            // 
            this.mainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.Location = new System.Drawing.Point(84, 747);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(281, 62);
            this.mainMenu.TabIndex = 43;
            this.mainMenu.Text = "Main Menu";
            this.mainMenu.UseVisualStyleBackColor = true;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(447, 747);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(281, 62);
            this.submit.TabIndex = 42;
            this.submit.Text = "Remove Part";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // RemovePart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 848);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.PartsListTotal);
            this.Name = "RemovePart";
            this.Text = "RemovePart";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox PartsListTotal;
        private System.Windows.Forms.Button mainMenu;
        private System.Windows.Forms.Button submit;
    }
}