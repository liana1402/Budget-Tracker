using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTracker
{
    public partial class RemoveCategory : Form
    {
        string existingCatName = default;
        public RemoveCategory(string cat)
        {
            InitializeComponent();
            existingCatName = cat;
            UpdateTheme();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            Database.ConnectDatabase();
            MySqlCommand commandDatabaseRemoveCategory = new MySqlCommand($"DELETE FROM category WHERE user_id = '{Database.userID}' AND category_name = '{existingCatName}'", Database.databaseConnection);
            commandDatabaseRemoveCategory.ExecuteReader();
            Database.databaseConnection.Close();
            Close();
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
