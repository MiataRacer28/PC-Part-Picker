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
    public partial class PCBuildScreen : Form
    {
        public PCBuildScreen()
        {
            InitializeComponent();
        }

        private void PCBuildScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //CPU Select
        {

        }

        private void button1_Click_1(object sender, EventArgs e) //Main Menu
        {
            MainMenu mainMenu = new MainMenu(); //Main menu form
            mainMenu.Show(); //show main menu
            this.Hide(); //hide database screen
        }

        private void GPUSelect_Click(object sender, EventArgs e) //GPU Select
        {

        }

        private void MBSelect_Click(object sender, EventArgs e) //Board select
        {

        }

        private void button1_Click_2(object sender, EventArgs e) //RAM Select
        {

        }
    }
}
