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

namespace PCPartPicker.Models
{
    public partial class RemovePart : Form
    {
        public RemovePart()
        {
            InitializeComponent();
            LoadParts();
        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu(); //Main menu form
            mainMenu.Show(); //show main menu
            this.Hide(); //hide database screen
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (PartsListTotal.SelectedItem != null)
            {
                string selectedPartName = PartsListTotal.SelectedItem.ToString();
                Database.DeletePart(selectedPartName);
                LoadParts();
            }
            else
            {
                ErrorScreen errorScreen = new ErrorScreen();
                errorScreen.ShowErrorMessage("No part selected");
                this.Hide();
                errorScreen.Show();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadParts()
        {
            PartsListTotal.Items.Clear();

            foreach (var part in Database.PartsList)
            {
                PartsListTotal.Items.Add(part.Name);
            }

        }

    }
}
