using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTracker
{
    public partial class EditCategory : Form
    {
        string existingCatName = default;
        public EditCategory(string cat)
        {
            InitializeComponent();
            UpdateTheme();
            existingCatName = cat;
            txtCategory.Text = existingCatName;
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            if(txtCategory.Text != "")
            {
                bool isLetter = Database.CheckChars(txtCategory.Text.Trim());
                if(isLetter == true)
                {
                    int catID = Database.GetCategoryID(existingCatName);
                    Database.ConnectDatabase();
                    MySqlCommand commandDatabaseEditCategory = new MySqlCommand($"UPDATE category SET category_name = '{txtCategory.Text}' WHERE user_id = '{Database.userID}' AND category_id = '{catID}'", Database.databaseConnection);
                    commandDatabaseEditCategory.ExecuteReader();
                    Database.databaseConnection.Close();
                    Close();
                }
                else
                {
                    MessageBox.Show("Please use valid characters.");
                }
            }
        }

        private void UpdateTheme()
        {
            int theme = Database.GetThemeIndex();
            Colors colorTheme = new Colors(theme);
            this.BackColor = colorTheme.Background;

            label1.ForeColor = colorTheme.Text;
            txtCategory.ForeColor = colorTheme.Text2;
            txtCategory.BackColor = colorTheme.TextBoxBack;
            btnSaveCategory.ForeColor = colorTheme.Text2;
            btnSaveCategory.BackColor = colorTheme.ButtonAndSelectedBack;
        }
    }
}
