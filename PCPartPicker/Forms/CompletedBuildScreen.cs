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
    public partial class CompletedBuildScreen: Form
    {
        public CompletedBuildScreen()
        {
            InitializeComponent();
            PopulateGridView();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu(); //Main menu form
            mainMenu.Show(); //show main menu
            this.Hide(); //hide database screen
        }

        private void PopulateGridView()
        {
            CompletedBuildsGrid.Rows.Clear(); //Clear residual data from grid


            //Add columns for each component type
            CompletedBuildsGrid.Columns.Add("CPU", "CPU");
            CompletedBuildsGrid.Columns.Add("GPU", "GPU");
            CompletedBuildsGrid.Columns.Add("RAM", "RAM");
            CompletedBuildsGrid.Columns.Add("Motherboard", "Motherboard");




            //Iterate through database list of builds and add info from each to grid
            foreach (var build in Database.CompletedBuildsList)
            {
                CompletedBuildsGrid.Rows.Add(build.Cpu.Name, build.Gpu.Name, build.Ram.Capacity, build.Mobo.Name);
            }

        }

        private void CompletedBuildsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
