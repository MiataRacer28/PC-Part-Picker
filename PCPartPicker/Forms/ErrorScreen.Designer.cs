namespace PCPartPicker.Forms
{
    partial class ErrorScreen
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
            this.ErrorAlert = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SpecifiedError = new System.Windows.Forms.TextBox();
            this.mainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ErrorAlert
            // 
            this.ErrorAlert.BackColor = System.Drawing.Color.LightCoral;
            this.ErrorAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorAlert.Location = new System.Drawing.Point(103, 103);
            this.ErrorAlert.MinimumSize = new System.Drawing.Size(586, 48);
            this.ErrorAlert.Name = "ErrorAlert";
            this.ErrorAlert.ReadOnly = true;
            this.ErrorAlert.Size = new System.Drawing.Size(586, 48);
            this.ErrorAlert.TabIndex = 0;
            this.ErrorAlert.Text = "The Following Error has Occured!";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SpecifiedError
            // 
            this.SpecifiedError.Location = new System.Drawing.Point(65, 279);
            this.SpecifiedError.MinimumSize = new System.Drawing.Size(658, 300);
            this.SpecifiedError.Multiline = true;
            this.SpecifiedError.Name = "SpecifiedError";
            this.SpecifiedError.ReadOnly = true;
            this.SpecifiedError.Size = new System.Drawing.Size(658, 300);
            this.SpecifiedError.TabIndex = 2;
            this.SpecifiedError.TextChanged += new System.EventHandler(this.SpecifiedError_TextChanged);
            // 
            // mainMenu
            // 
            this.mainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.Location = new System.Drawing.Point(254, 685);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(281, 62);
            this.mainMenu.TabIndex = 26;
            this.mainMenu.Text = "Main Menu";
            this.mainMenu.UseVisualStyleBackColor = true;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // ErrorScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 848);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.SpecifiedError);
            this.Controls.Add(this.ErrorAlert);
            this.Name = "ErrorScreen";
            this.Text = "ErrorScreen";
            this.Load += new System.EventHandler(this.ErrorScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ErrorAlert;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox SpecifiedError;
        private System.Windows.Forms.Button mainMenu;
    }
}