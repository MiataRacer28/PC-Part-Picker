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

        private void addCPU_Click(object sender, EventArgs e)
        {
            AddCPU addCPU = new AddCPU();
            addCPU.Show();
            this.Hide();
        }

        private void addGPU_Click(object sender, EventArgs e)
        {
            AddGPU addGPU = new AddGPU(); 
            addGPU.Show(); 
            this.Hide(); 
        }

        private void addRAM_Click(object sender, EventArgs e)
        {
            AddRAM addRAM = new AddRAM(); 
            addRAM.Show(); 
            this.Hide(); 
        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu(); //Main menu form
            mainMenu.Show(); //show main menu
            this.Hide(); //hide database screen
        }

        private void addMobo_Click(object sender, EventArgs e)
        {
            AddMotherboard addMotherboard = new AddMotherboard();
            addMotherboard.Show();
            this.Hide();
        }
    }
}
