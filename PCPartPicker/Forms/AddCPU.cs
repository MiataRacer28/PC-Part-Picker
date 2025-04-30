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
    public partial class AddCPU: Form
    {
        public AddCPU()
        {
            InitializeComponent();
        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu(); //Main menu form
            mainMenu.Show(); //show main menu
            this.Hide(); //hide database screen
        }

        //Will retrieve data from each text box, convert to correct data type, pass data into a new object constructor, and update the database
        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                string name = (string)(cpuNameEntry.Text);
                string manufacturer = (string)(cpuManufacturerEntry.Text);
                int performanceScore = int.Parse(pfScoreEntry.Text);
                int coreCount = int.Parse(coreCountEntry.Text);
                double clockFreq = double.Parse(clockFreqEntry.Text);   
                int maxTDP = int.Parse(maxTDPEntry.Text);   
                string architecture = (string)(cpuArchEntry.Text);
                bool integratedGfx = bool.Parse(intGpuEntry.Text);
                string socket = (string)(socketEntry.Text);

                CPU cpuAddition = new CPU(name, manufacturer, performanceScore, coreCount, clockFreq, maxTDP, architecture, integratedGfx, socket);
                Database.UpdateDatabase(cpuAddition);

                MainMenu mainMenu = new MainMenu(); //Main menu form
                mainMenu.Show(); //show main menu
                this.Hide(); //hide database screen
            }

            catch (Exception ex)
            {
                ErrorScreen errorScreen = new ErrorScreen();
                errorScreen.ShowErrorMessage(ex.Message);
                this.Hide();
                errorScreen.Show();
            }


        }
    }
}
