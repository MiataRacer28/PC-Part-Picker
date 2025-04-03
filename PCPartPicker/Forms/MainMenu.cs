using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCPartPicker
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            Database.LoadDatabase();
        }

        private void PartsDatabase_Click(object sender, EventArgs e)
        {
            DatabaseScreen databaseScreen = new DatabaseScreen(); // Use database screen
            databaseScreen.Show(); //show screen
            this.Hide(); // Hide the main form
        }

        private void BuildPC_Click(object sender, EventArgs e)
        {
            PCBuildScreen pcBuildScreen = new PCBuildScreen(); //Use PCBuild Screen
            pcBuildScreen.Show(); //show screen
            this.Hide(); // Hide the main form
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e) //Exit
        {
            this.Close(); //shutdown application
        }

        private void CompletedBuilds_Click(object sender, EventArgs e) //View Completed Builds Screen
        {
            CompletedBuildScreen completedBuildScreen = new CompletedBuildScreen();
            completedBuildScreen.Show();
            this.Hide();
        }
    }
}
