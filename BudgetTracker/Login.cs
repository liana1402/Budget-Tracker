using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace BudgetTracker
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            Visible = false;
        }

        private void txtUsernameInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) txtPasswordInput.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void txtPasswordInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) LogIn();
        }

        private void LogIn()
        {
            bool accountExists = false;

            //verifying account
            Database.ConnectDatabase();
            MySqlCommand commandDatabaseCheck = new MySqlCommand($"SELECT COUNT(username) FROM account WHERE username = '{txtUsernameInput.Text}' AND password = '{txtPasswordInput.Text}'", Database.databaseConnection);
            MySqlDataReader readerCheck = commandDatabaseCheck.ExecuteReader();

            while (readerCheck.Read())
            {
                accountExists = readerCheck.GetBoolean(0);
            }
            Database.databaseConnection.Close();

            if (accountExists == true)
            {
                Database.SetUserID(txtUsernameInput.Text);
                Main main = new Main();
                main.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Incorrect username or password.");
            }
        }

    }
}
