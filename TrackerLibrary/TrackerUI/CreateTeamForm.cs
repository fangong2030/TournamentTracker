using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void deleteSelectedPlayerButton_Click(object sender, EventArgs e)
        {

        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
           
        }

        private bool ValidateForm()
        {
            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }
            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }
            if (emailValue.Text.Length == 0)
            {
                return false;
            }
            if (cellphoneValue.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel person = new PersonModel(firstNameValue.Text, lastNameValue.Text, emailValue.Text, cellphoneValue.Text);

                // TODO - CreateTeam in IDataConnection
                GlobalConfig.Connection.CreatePerson(person);

                //firstNameValue.Text = "";
                //lastNameValue.Text = "";
                //emailValue.Text = "";
                //cellphoneValue.Text = "";

            }
            else
            {
                MessageBox.Show("This form has invalid information, Please try again.");
            }
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {

        }
    }
}
