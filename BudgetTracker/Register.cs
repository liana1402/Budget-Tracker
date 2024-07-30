using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BudgetTracker
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void txtUsernameInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) txtPasswordInput.Focus();
        }

        private void txtPasswordInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) txtConfirmPasswordInput.Focus();
        }

        private void txtConfirmPasswordInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) Registering();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Visible = true;
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registering();
        }

        private void Registering()
        {
            bool continueWithAcc = false;
            bool passwordCheck = false;

            if(txtUsernameInput.Text == "" || txtPasswordInput.Text == "")
            {
                MessageBox.Show("Please enter a username and password.");
                return;
            }
            //check username
            if (Database.CheckChars(txtUsernameInput.Text.Trim()) == false)
            {
                MessageBox.Show("Please use valid characters.");
                return;
            }
            else if (Database.CheckUsername(txtUsernameInput.Text.Trim()) == true)
            {
                MessageBox.Show("This username already exists.");
                return;
            }
            else if (txtUsernameInput.Text.Length < 3)
            {
                MessageBox.Show("Username has to be 3 or more characters.");
                return;
            }
            else
            {
                continueWithAcc = true;
            }

            //check password
            if (Database.CheckChars(txtPasswordInput.Text.Trim()) == false)
            {
                MessageBox.Show("Please use valid characters.");
                return;
            }
            else if (txtPasswordInput.Text != txtConfirmPasswordInput.Text)
            {
                MessageBox.Show("Passwords do not match. Please Try again");
                return;
            }
            else
            {
                passwordCheck = true;
            }

            //verify and continue
            if (continueWithAcc == true && passwordCheck == true)
            {
                Database.ConnectDatabase();
                MySqlCommand commandDatabaseAdd = new MySqlCommand($"INSERT INTO account (username, password) VALUES ('{txtUsernameInput.Text.Trim()}', '{txtPasswordInput.Text}')", Database.databaseConnection);
                commandDatabaseAdd.ExecuteReader();
                Database.databaseConnection.Close();
                Database.SetUserID(txtUsernameInput.Text.Trim());

                Main main = new Main();
                main.Show();
                Visible = false;
            }
        }
    }
}
