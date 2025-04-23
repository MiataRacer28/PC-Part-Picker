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
    public partial class PartToAdd: Form
    {
        public PartToAdd()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //User opts to add CPU
        private void addCPU_Click(object sender, EventArgs e)
        {
            AddCPU addCPU = new AddCPU(); //CPU Form
            addCPU.Show(); //display 
            this.Hide(); //hide current
        }

        //User opts to add GPU
        private void addGPU_Click(object sender, EventArgs e)
        {
            AddGPU addGPU = new AddGPU(); //GPU form
            addGPU.Show(); //display
            this.Hide(); //hide current
        }

        //User opts to add RAM
        private void addRAM_Click(object sender, EventArgs e)
        {
            AddRAM addRAM = new AddRAM(); //RAM form
            addRAM.Show(); //display ram form
            this.Hide(); //hide current
        }

        //User opts to return home
        private void mainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu(); //Main menu form
            mainMenu.Show(); //show main menu
            this.Hide(); //hide current screen
        }

        //User opts to add Motherboard
        private void addMobo_Click(object sender, EventArgs e)
        {
            AddMotherboard addMotherboard = new AddMotherboard(); //Motherboard form
            addMotherboard.Show(); //display motherboard form
            this.Hide(); //hide current
        }
    }
}
