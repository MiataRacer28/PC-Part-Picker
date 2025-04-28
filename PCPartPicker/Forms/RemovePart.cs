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
            this.Hide(); //hide current screen
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (PartsListTotal.SelectedItem != null)
            {
                //Will retrive name from selected component and remove it (part) from database
                string selectedPartName = PartsListTotal.SelectedItem.ToString();
                Database.DeletePart(selectedPartName);
                LoadParts(); //Reload list
            }
            else
            { //If failure occurs, redirect user to error screen and show the error message
                ErrorScreen errorScreen = new ErrorScreen();
                errorScreen.ShowErrorMessage("No part selected");
                this.Hide();
                errorScreen.Show();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadParts() //Populate the list via components from the database
        {
            PartsListTotal.Items.Clear(); //Clear residual parts then list all parts again 

            foreach (var part in Database.PartsList)
            {
                PartsListTotal.Items.Add(part.Name);
            }

        }

    }
}
