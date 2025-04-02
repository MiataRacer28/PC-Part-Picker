namespace PCPartPicker
{
    partial class CompletedBuildScreen
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
            this.completedBuildScreenMainTitle = new System.Windows.Forms.TextBox();
            this.mainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // completedBuildScreenMainTitle
            // 
            this.completedBuildScreenMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completedBuildScreenMainTitle.Location = new System.Drawing.Point(120, 62);
            this.completedBuildScreenMainTitle.Name = "completedBuildScreenMainTitle";
            this.completedBuildScreenMainTitle.ReadOnly = true;
            this.completedBuildScreenMainTitle.Size = new System.Drawing.Size(566, 62);
            this.completedBuildScreenMainTitle.TabIndex = 0;
            this.completedBuildScreenMainTitle.Text = "Completed Builds";
            this.completedBuildScreenMainTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.completedBuildScreenMainTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mainMenu
            // 
            this.mainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.Location = new System.Drawing.Point(776, 62);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(281, 62);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "Main Menu";
            this.mainMenu.UseVisualStyleBackColor = true;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // CompletedBuildScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1136, 888);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.completedBuildScreenMainTitle);
            this.Name = "CompletedBuildScreen";
            this.Text = "CompletedBuildScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox completedBuildScreenMainTitle;
        private System.Windows.Forms.Button mainMenu;
    }
}