using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCPartPicker.Forms
{
    public partial class AddRAM: Form
    {
        public AddRAM()
        {
            InitializeComponent();
        }

        private void capacityEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu(); //Main menu form
            mainMenu.Show(); //show main menu
            this.Hide(); //hide current screen
        }
        //Will retrieve data from each text box, convert to correct data type, pass data into a new object constructor, and update the database
        private void submit_Click(object sender, EventArgs e) 
        {
            try
            {
                string name = (string)(ramNameEntry.Text);
                string manufacturer = (string)(ramManufacturerEntry.Text);
                int performanceScore = int.Parse(pfScoreEntry.Text);
                int capacity = int.Parse(capacityEntry.Text);
                string memType = (string)(memTypeEntry.Text);
                int memFrequency = int.Parse(memFreqEntry.Text);
                string latency = (string)(latencyEntry.Text);
                string voltage = (string)(voltageEntry.Text);
                bool errorCorrecting = bool.Parse(eccEntry.Text);

                RAM ramAddition = new RAM(name, manufacturer, performanceScore, capacity, memType, memFrequency, latency, voltage, errorCorrecting);
                Database.UpdateDatabase(ramAddition);

                MainMenu mainMenu = new MainMenu(); //Main menu form
                mainMenu.Show(); //show main menu
                this.Hide(); //hide current screen
            }

            catch (Exception ex)
            {
                //if failure, redirect user to error screen and display error message
                ErrorScreen errorScreen = new ErrorScreen();
                errorScreen.ShowErrorMessage(ex.Message);
                this.Hide();
                errorScreen.Show();
            }


        }

        private void ramNameEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void ramName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
