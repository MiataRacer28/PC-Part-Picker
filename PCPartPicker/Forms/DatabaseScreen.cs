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
using PCPartPicker.Models;

namespace PCPartPicker
{
    public partial class DatabaseScreen : Form
    {
        public DatabaseScreen()
        {
            InitializeComponent();
        }

        private void DatabaseScreen_Load(object sender, EventArgs e)
        {

        }

        private void AddPart_click(object sender, EventArgs e)
        {
            PartToAdd partToAdd = new PartToAdd(); //Select part to add form
            partToAdd.Show(); //display
            this.Hide(); //hide current
        }

        private void MainMenuReturn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu(); //Main menu form
            mainMenu.Show(); //show main menu
            this.Hide(); //hide database screen
        }

        private void removePart_Click(object sender, EventArgs e)
        {
            RemovePart removePart = new RemovePart(); //Remove part form
            this.Hide(); //hide current
            removePart.Show(); //show remove part form
        }
    }
}
