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
    public partial class AddMotherboard: Form
    {
        public AddMotherboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void MaxMemSpeedEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu(); //Main menu form
            mainMenu.Show(); //show main menu
            this.Hide(); //hide database screen
        }

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_4(object sender, EventArgs e)
        {

        }

        private void Submit(object sender, EventArgs e)
        {
            try
            {
                string name = (string)(moboNameEntry.Text);
                string manufacturer = (string)(MoboManufacturerEntry.Text);
                int performanceScore = int.Parse(pfScoreEntry.Text);
                string formFactor = (string)(FormFactorEntry.Text);
                string socket = (string)(SocketEntry.Text);
                string chipset = (string)(ChipsetEntry.Text);
                string memType = (string)(MemTypeEntry.Text);
                int maxMem = int.Parse(MaxMemEntry.Text);
                int maxMemSpeed = int.Parse(maxMemSpeedEntry.Text);
                int pcieSlotNum = int.Parse(PcieSlotNEntry.Text);
                string maxPCIeSlotType = (string)(maxPCIeSlotTypeEntry.Text);
                string PCIeVer = (string)(PCIeVersionEntry.Text);

                Motherboard moboAddition = new Motherboard(name, manufacturer, performanceScore, formFactor, socket, chipset, memType, maxMem, maxMemSpeed, pcieSlotNum, maxPCIeSlotType, PCIeVer);
                Database.UpdateDatabase(moboAddition);

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
