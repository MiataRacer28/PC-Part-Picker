namespace PCPartPicker
{
    partial class MainMenu
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
            this.PartsDatabase = new System.Windows.Forms.Button();
            this.BuildPC = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.ViewCompletedBuilds = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PartsDatabase
            // 
            this.PartsDatabase.BackColor = System.Drawing.Color.Turquoise;
            this.PartsDatabase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.PartsDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsDatabase.Location = new System.Drawing.Point(235, 43);
            this.PartsDatabase.Name = "PartsDatabase";
            this.PartsDatabase.Size = new System.Drawing.Size(333, 183);
            this.PartsDatabase.TabIndex = 0;
            this.PartsDatabase.Text = "Parts Database";
            this.PartsDatabase.UseVisualStyleBackColor = false;
            this.PartsDatabase.Click += new System.EventHandler(this.PartsDatabase_Click);
            // 
            // BuildPC
            // 
            this.BuildPC.BackColor = System.Drawing.Color.Turquoise;
            this.BuildPC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.BuildPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuildPC.Location = new System.Drawing.Point(235, 253);
            this.BuildPC.Name = "BuildPC";
            this.BuildPC.Size = new System.Drawing.Size(333, 183);
            this.BuildPC.TabIndex = 1;
            this.BuildPC.Text = "Build PC";
            this.BuildPC.UseVisualStyleBackColor = false;
            this.BuildPC.Click += new System.EventHandler(this.BuildPC_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Turquoise;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(235, 717);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(333, 183);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ViewCompletedBuilds
            // 
            this.ViewCompletedBuilds.BackColor = System.Drawing.Color.Turquoise;
            this.ViewCompletedBuilds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCompletedBuilds.Location = new System.Drawing.Point(235, 464);
            this.ViewCompletedBuilds.Name = "ViewCompletedBuilds";
            this.ViewCompletedBuilds.Size = new System.Drawing.Size(333, 183);
            this.ViewCompletedBuilds.TabIndex = 3;
            this.ViewCompletedBuilds.Text = "View Completed Builds";
            this.ViewCompletedBuilds.UseVisualStyleBackColor = false;
            this.ViewCompletedBuilds.Click += new System.EventHandler(this.CompletedBuilds_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(798, 1021);
            this.Controls.Add(this.ViewCompletedBuilds);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.BuildPC);
            this.Controls.Add(this.PartsDatabase);
            this.MaximumSize = new System.Drawing.Size(826, 1100);
            this.MinimumSize = new System.Drawing.Size(826, 1100);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PartsDatabase;
        private System.Windows.Forms.Button BuildPC;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button ViewCompletedBuilds;
    }
}

