using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCPartPicker.Forms;

namespace PCPartPicker
{
    public partial class PCBuildScreen : Form
    {

        CPU SelectedCPU;
        GPU SelectedGPU;
        RAM SelectedRAM;
        Motherboard SelectedMobo;
        public PCBuildScreen()
        {
            InitializeComponent();
            LoadGPUs();
            LoadCPUs();
            LoadRAM();
            LoadMobos();


        }

        private void PCBuildScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //CPU Select
        {
            if (cpuList.SelectedItem != null)
            {
                SelectedCPU = cpuList.SelectedItem as CPU;
            }
            else
            {
                ErrorScreen errorScreen = new ErrorScreen();
                errorScreen.ShowErrorMessage("No CPU selected");
                this.Hide();
                errorScreen.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e) //Main Menu
        {
            MainMenu mainMenu = new MainMenu(); //Main menu form
            mainMenu.Show(); //show main menu
            this.Hide(); //hide database screen
        }

        private void GPUSelect_Click(object sender, EventArgs e) //GPU Select
        {
            if (gpuList.SelectedItem != null)
            {
               SelectedGPU = gpuList.SelectedItem as GPU;
            }
            else
            {
                ErrorScreen errorScreen = new ErrorScreen();
                errorScreen.ShowErrorMessage("No GPU selected");
                this.Hide();
                errorScreen.Show();
            }
        }

        private void MBSelect_Click(object sender, EventArgs e) //Board select
        {
            if (motherboardList.SelectedItem != null)
            {
                SelectedMobo = motherboardList.SelectedItem as Motherboard;
            }
            else
            {
                ErrorScreen errorScreen = new ErrorScreen();
                errorScreen.ShowErrorMessage("No Motherboard selected");
                this.Hide();
                errorScreen.Show();
            }
        }

        private void button1_Click_2(object sender, EventArgs e) //RAM Select
        {
            if (ramList.SelectedItem != null)
            {
                SelectedRAM = ramList.SelectedItem as RAM;
            }
            else
            {
                ErrorScreen errorScreen = new ErrorScreen();
                errorScreen.ShowErrorMessage("No RAM selected");
                this.Hide();
                errorScreen.Show();
            }
        }

        private void LoadGPUs()
        {
            gpuList.Items.Clear();

            foreach (var part in Database.PartsList)
            {
                if (part is GPU)
                    gpuList.Items.Add(part);
            }

        }

        private void LoadCPUs()
        {
            cpuList.Items.Clear();

            foreach (var part in Database.PartsList)
            {
                if (part is CPU)
                    cpuList.Items.Add(part);
            }

        }

        private void LoadRAM()
        {
            ramList.Items.Clear();

            foreach (var part in Database.PartsList)
            {
                if (part is RAM)
                    ramList.Items.Add(part);
            }

        }

        private void LoadMobos()
        {
            motherboardList.Items.Clear();
            foreach (var part in Database.PartsList)
            {
                if (part is Motherboard)
                    motherboardList.Items.Add(part);
            }
        }

        private void CreateBuild_Click(object sender, EventArgs e)
        {
            try
            {

                if (SelectedCPU.Socket != SelectedMobo.Socket)
                {
                    throw new InvalidSocketError();
                }
                CompletedBuild newBuild = new CompletedBuild(SelectedCPU, SelectedGPU, SelectedRAM, SelectedMobo);
                Database.WriteBuildToDatabase(newBuild);
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
