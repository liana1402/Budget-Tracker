using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTracker
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            UpdateTheme();

            //set username value
            txtUsername.Text = Database.GetUsername();
            //set current month budget
            nudCurrentMonthBudget.Value = Convert.ToDecimal(Database.GetMonthlyBudget(DateTime.Now.Month));
            //set red zone
            nudRedZone.Value = Convert.ToDecimal(Database.GetRedZone(DateTime.Now.Month));
            //set category table
            UpdateCategoryBudget();

            //set themes
            cbDisplayTheme.Items.Add("Default");
            cbDisplayTheme.Items.Add("Dark");
            cbDisplayTheme.Items.Add("Dark Neutral");
            cbDisplayTheme.SelectedIndex = Database.GetThemeIndex();
        }

        private void btnSaveAccountChanges_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "" && txtUsername.Text != "")
            {
                bool isUsernameLetter = Database.CheckChars(txtUsername.Text.Trim());
                bool isPasswordLetter = Database.CheckChars(txtPassword.Text.Trim());
                if (isUsernameLetter == true && isPasswordLetter == true)
                {
                    //check if username has been edited
                    if (txtUsername.Text == Database.GetUsername())
                    {
                        Database.ConnectDatabase();
                        MySqlCommand commandDatabaseChangeAcc = new MySqlCommand($"UPDATE account SET password = '{txtPassword.Text}' WHERE user_id = {Database.userID};", Database.databaseConnection);
                        commandDatabaseChangeAcc.ExecuteReader();
                        Database.databaseConnection.Close();
                        MessageBox.Show("Password has been changed.");
                    }
                    else
                    {
                        //check if username exists
                        bool accountExists = Database.CheckUsername(txtUsername.Text.Trim());
                        if (accountExists == false)
                        {
                            Database.ConnectDatabase();
                            MySqlCommand commandDatabaseChangeAcc = new MySqlCommand($"UPDATE account SET username = '{txtUsername.Text.Trim()}', password = '{txtPassword.Text}' WHERE user_id = {Database.userID};", Database.databaseConnection);
                            commandDatabaseChangeAcc.ExecuteReader();
                            Database.databaseConnection.Close();
                            MessageBox.Show("Username and password have been changed.");
                        }
                        else
                        {
                            MessageBox.Show("This username already exists.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid characters.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a password and username.");
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            DeleteAccount deleteAccount = new DeleteAccount();
            deleteAccount.ShowDialog();
        }

        private void btnSaveBudgetChanges_Click(object sender, EventArgs e)
        {
            if (nudCurrentMonthBudget.Text == "" || nudCurrentMonthBudget.Text == "0.00")
            {
                MessageBox.Show("Please enter a budget for the month.");
            }
            else
            {
                //get current month
                string currentDate = DateTime.Now.ToString();
                string[] dateComponents = currentDate.Split('/');
                int month = Convert.ToInt32(dateComponents[1]);

                //check if month budget exists for current month
                int monthExists = default;
                Database.ConnectDatabase();
                MySqlCommand commandDatabaseMonthExists = new MySqlCommand($"SELECT COUNT(month) FROM monthlybudget WHERE user_id = {Database.userID} AND month = {month}", Database.databaseConnection);
                MySqlDataReader readerMonthExists = commandDatabaseMonthExists.ExecuteReader();
                while (readerMonthExists.Read())
                {
                    monthExists = readerMonthExists.GetInt32(0);
                }
                Database.databaseConnection.Close();

                if (nudRedZone.Text == "") //if no red zone
                {
                    string MB = float.Parse(nudCurrentMonthBudget.Text.Trim(), NumberStyles.Currency).ToString();
                    if (monthExists == 0) //if does not exist
                    {
                        Database.ConnectDatabase();
                        MySqlCommand commandDatabaseAddMonthBudget = new MySqlCommand($"INSERT INTO monthlybudget (user_id, month, month_budget, red_zone) VALUES({Database.userID},{month},{MB}, 0)", Database.databaseConnection);
                        commandDatabaseAddMonthBudget.ExecuteReader();
                        Database.databaseConnection.Close();
                        MessageBox.Show("Monthly budget has been added.");
                    }
                    else //if exists
                    {
                        Database.ConnectDatabase();
                        MySqlCommand commandDatabaseChangeMonthBudget = new MySqlCommand($"UPDATE monthlybudget SET month_budget = '{MB}', red_zone = 0 WHERE user_id = {Database.userID} AND month = {month};", Database.databaseConnection);
                        commandDatabaseChangeMonthBudget.ExecuteReader();
                        Database.databaseConnection.Close();
                        MessageBox.Show("Monthly budget has been updated.");
                    }
                }
                else //if with red zone
                {
                    string MB = float.Parse(nudCurrentMonthBudget.Text.Trim(), NumberStyles.Currency).ToString();
                    string RZ = float.Parse(nudRedZone.Text.Trim(), NumberStyles.Currency).ToString();
                    if (monthExists == 0) //if does not exist
                    {
                        Database.ConnectDatabase();
                        MySqlCommand commandDatabaseAddMonthBudget = new MySqlCommand($"INSERT INTO monthlybudget (user_id, month, month_budget, red_zone) VALUES({Database.userID},{month},{MB},{RZ})", Database.databaseConnection);
                        commandDatabaseAddMonthBudget.ExecuteReader();
                        Database.databaseConnection.Close();
                        MessageBox.Show("Monthly budget has been added.");
                    }
                    else //if exists
                    {
                        Database.ConnectDatabase();
                        MySqlCommand commandDatabaseChangeMonthBudget = new MySqlCommand($"UPDATE monthlybudget SET month_budget = '{MB}', red_zone = '{RZ}' WHERE user_id = {Database.userID} AND month = {month};", Database.databaseConnection);
                        commandDatabaseChangeMonthBudget.ExecuteReader();
                        Database.databaseConnection.Close();
                        MessageBox.Show("Monthly budget has been updated.");
                    }
                }
            }
        }

        private void btnSaveCategoryBudgetChanges_Click(object sender, EventArgs e)
        {
            float totalBudgets = 0;
            foreach (DataGridViewRow row in dgvCategoryBudgets.Rows)
            {
                string category = row.Cells[0].Value.ToString();
                float budget = default;
                if (row.Cells[1].Value.ToString().Trim() != "" || row.Cells[1].Value != null || row.Cells[1].Value != DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[1].Value.ToString()) == false)
                {
                    budget = (float)row.Cells[2].Value;
                }
                else
                {
                    budget = 0;
                }

                totalBudgets += budget;
                if (totalBudgets > Database.GetMonthlyBudget(DateTime.Now.Month))
                {
                    MessageBox.Show("Your category budgets should not exceed your monthly budget.");
                    return;
                }
                int categoryID = Database.GetCategoryID(category);
                Database.ConnectDatabase();
                MySqlCommand commandDatabaseSaveCategoryBudget = new MySqlCommand($"UPDATE categorybudget SET category_budget = '{budget}' WHERE category_id = {categoryID};", Database.databaseConnection);
                commandDatabaseSaveCategoryBudget.ExecuteReader();
                Database.databaseConnection.Close();
            }
            UpdateCategoryBudget();
        }

        private void dgvCategoryBudgets_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.FormattedValue.ToString() == "")
            {
                e.Cancel = true;

            }
        }

        private void lblRedZoneHelp_MouseHover(object sender, EventArgs e)
        {
            lblRedZone.Visible = true;
        }

        private void lblRedZoneHelp_MouseLeave(object sender, EventArgs e)
        {
            lblRedZone.Visible = false;
        }

        private void cbDisplayTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            string theme = default;
            if (cbDisplayTheme.SelectedIndex == 0)
            {
                theme = "default";
            }
            else if (cbDisplayTheme.SelectedIndex == 1)
            {
                theme = "dark";
            }
            else if (cbDisplayTheme.SelectedIndex == 2)
            {
                theme = "dark_neutral";
            }
            Database.ConnectDatabase();
            MySqlCommand commandDatabaseChangeTheme = new MySqlCommand($"UPDATE account SET display_theme = '{theme}' WHERE user_id = {Database.userID};", Database.databaseConnection);
            commandDatabaseChangeTheme.ExecuteReader();
            Database.databaseConnection.Close();
            UpdateTheme();
        }

        private void UpdateCategoryBudget()
        {
            List<Categories> categoriesList = Database.GetCategories();
            dgvCategoryBudgets.DataSource = categoriesList;
            dgvCategoryBudgets.Columns["Amount"].Visible = false;
            dgvCategoryBudgets.Columns["Category"].Width = 120;
            dgvCategoryBudgets.Columns["Category"].ReadOnly = true;
            dgvCategoryBudgets.Columns["Budget"].Width = 120;
            dgvCategoryBudgets.Columns["Budget"].DefaultCellStyle.Format = "c";
        }

        private void UpdateTheme()
        {
            System.Windows.Forms.TextBox[] textboxes = new[] { txtUsername, txtPassword };
            System.Windows.Forms.Label[] lables = new[] { label1, label2, label3, label4, label5, label6, label8, label9, label10, lblRedZoneHelp };
            System.Windows.Forms.Button[] buttons = new[] { btnDeleteAccount, btnSaveAccountChanges, btnSaveBudgetChanges, btnSaveCategoryBudgetChanges };
            int theme = Database.GetThemeIndex();
            Colors colorTheme = new Colors(theme);
            this.BackColor = colorTheme.Background;

            foreach (var item in lables)
            {
                item.ForeColor = colorTheme.Text;
            }
            foreach (var item in textboxes)
            {
                item.ForeColor = colorTheme.Text2;
                item.BackColor = colorTheme.TextBoxBack;
            }
            foreach (var item in buttons)
            {
                item.ForeColor = colorTheme.Text2;
                item.BackColor = colorTheme.ButtonAndSelectedBack;
            }

            nudCurrentMonthBudget.ForeColor = colorTheme.Text2;
            nudCurrentMonthBudget.BackColor = colorTheme.TextBoxBack;
            nudRedZone.ForeColor = colorTheme.Text2;
            nudRedZone.BackColor = colorTheme.TextBoxBack;

            lblRedZone.ForeColor = colorTheme.Text2;
            lblRedZone.BackColor = colorTheme.TableBack;
            btnSaveCategoryBudgetChanges.BackColor = colorTheme.TextBoxBack;
            cbDisplayTheme.ForeColor = colorTheme.Text2;
            cbDisplayTheme.BackColor = colorTheme.ButtonAndSelectedBack;

            dgvCategoryBudgets.DefaultCellStyle.SelectionBackColor = colorTheme.ButtonAndSelectedBack;
            dgvCategoryBudgets.DefaultCellStyle.SelectionForeColor = colorTheme.Text;
            dgvCategoryBudgets.DefaultCellStyle.BackColor = colorTheme.TableBack;
            dgvCategoryBudgets.DefaultCellStyle.ForeColor = colorTheme.Text2;
            dgvCategoryBudgets.BackgroundColor = colorTheme.TableBack;
            dgvCategoryBudgets.ColumnHeadersDefaultCellStyle.BackColor = colorTheme.TableBack;
            dgvCategoryBudgets.ColumnHeadersDefaultCellStyle.ForeColor = colorTheme.Text2;
            dgvCategoryBudgets.ColumnHeadersDefaultCellStyle.SelectionBackColor = colorTheme.TableBack;
            dgvCategoryBudgets.GridColor = colorTheme.Grid;
        }
    }
}
