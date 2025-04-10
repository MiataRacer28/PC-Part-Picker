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
    public partial class AddGPU: Form
    {
        public AddGPU()
        {
            InitializeComponent();
        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu(); //Main menu form
            mainMenu.Show(); //show main menu
            this.Hide(); //hide database screen
        }

        private void coreCountEntry_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void baseClockEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void maxClockEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void gpuArchEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void vramEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void memTypeEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void maxTDPEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void raytracingEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void gfxAPIEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                string name = (string)(gpuNameEntry.Text);
                string manufacturer = (string)(gpuManufacturerEntry.Text);
                int performanceScore = int.Parse(pfScoreEntry.Text);
                int coreCount = int.Parse(coreCountEntry.Text);
                int baseClock = int.Parse(baseClockEntry.Text);
                int maxClock = int.Parse(maxClockEntry.Text);
                string gpuArch = (string)gpuArchEntry.Text;
                int VRAM = int.Parse(vramEntry.Text);
                string memType = (string)memTypeEntry.Text;
                int maxTDP = int.Parse(maxTDPEntry.Text);
                bool hasRaytracing = bool.Parse(raytracingEntry.Text);
                string recentGraphicsAPI = (string)(gfxAPIEntry.Text);

                GPU gpuAddition = new GPU(name, manufacturer, performanceScore, coreCount, baseClock, maxClock, gpuArch, VRAM, memType, maxTDP, hasRaytracing, recentGraphicsAPI);
                Database.UpdateDatabase(gpuAddition);

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

        private void gpuNameEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void gpuManufacturerEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void pfScoreEntry_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
