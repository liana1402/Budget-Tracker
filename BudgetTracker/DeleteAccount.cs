using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTracker
{
    public partial class DeleteAccount : Form
    {
        public DeleteAccount()
        {
            InitializeComponent();
            UpdateTheme();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            Database.ConnectDatabase();
            MySqlCommand commandDatabaseDeleteAcc = new MySqlCommand($"DELETE FROM account WHERE user_id = '{Database.userID}'", Database.databaseConnection);
            commandDatabaseDeleteAcc.ExecuteReader();
            Database.databaseConnection.Close();
            Environment.Exit(0);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateTheme()
        {
            int theme = Database.GetThemeIndex();
            Colors colorTheme = new Colors(theme);
            this.BackColor = colorTheme.Background;

            label1.ForeColor = colorTheme.Text;
            label2.ForeColor = colorTheme.Text;
            btnDeleteAccount.ForeColor = colorTheme.Text2;
            btnDeleteAccount.BackColor = colorTheme.ButtonAndSelectedBack;
            btnCancel.ForeColor = colorTheme.Text2;
            btnCancel.BackColor = colorTheme.ButtonAndSelectedBack;
        }
    }
}
