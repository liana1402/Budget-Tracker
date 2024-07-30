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

namespace BudgetTracker
{
    public partial class AddTransaction : Form
    {
        public AddTransaction()
        {
            InitializeComponent();
            UpdateTheme();

            //set categories
            Database.ConnectDatabase();
            MySqlCommand commandDatabaseGetCategories = new MySqlCommand($"SELECT category_name FROM category WHERE user_id = '{Database.userID}'", Database.databaseConnection);
            MySqlDataReader readerGetCategories = commandDatabaseGetCategories.ExecuteReader();

            while (readerGetCategories.Read())
            {
                cbNewTransactionCategory.Items.Add(readerGetCategories.GetString(0));
            }
            Database.databaseConnection.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool continueToSave = true;
            if (cbNewTransactionCategory.Text == "")
            {
                MessageBox.Show("Please select a category.");
                continueToSave = false;
            } 
            else if (cbIncome.Checked == false && cbExpense.Checked == false)
            {
                MessageBox.Show("Please indicate whether this is an income or expense.");
                continueToSave = false;
            }
            else if (cbIncome.Checked == true && cbExpense.Checked == true)
            {
                MessageBox.Show("Please indicate whether this is an income or expense.");
                continueToSave = false;
            }
            else if(cbMonthly.Checked == true && cbWeekly.Checked == true)
            {
                MessageBox.Show("Please indicate whether this repeats weekly or monthly.");
                continueToSave = false;
            }
            else if(txtNewTransactionDescription.Text != "")
            {
                continueToSave = Database.CheckChars(txtNewTransactionDescription.Text.Trim());
                if(continueToSave == false)
                {
                    MessageBox.Show("Please use valid characters in description.");
                }
            }
            if(continueToSave == true)
            {
                string repeatedStatus = "not";
                if (cbWeekly.Checked == true)
                {
                    repeatedStatus = "weekly";
                }
                else if (cbMonthly.Checked == true)
                {
                    repeatedStatus = "monthly";
                }

                float amount = Convert.ToSingle(nudNewTransactionAmount.Value);
                if (cbExpense.Checked == true)
                {
                    amount = -(amount);
                }

                int categoryID = Database.GetCategoryID(cbNewTransactionCategory.Text);
                float balanceAfterTransaction = Convert.ToSingle(Database.GetCurrentBalance()) + amount;
                string[] dateComponents = dtpNewTransactionDate.Text.Split('/');
                string date = dateComponents[2] + "-" + dateComponents[1] + "-" + dateComponents[0];
                Database.AddTransaction(categoryID, date, txtNewTransactionDescription.Text, amount, repeatedStatus, balanceAfterTransaction);

                //check budget
                if (cbExpense.Checked == true)
                {
                    if (Database.GetMonthlyExpense(DateTime.Now.Month) <= -(Database.GetMonthlyBudget(DateTime.Now.Month)))
                    {
                        MessageBox.Show("Please be alterted that your monthly budget has been reached.");
                    }
                    else if (Database.GetMonthlyExpense(DateTime.Now.Month) <= -((Database.GetMonthlyBudget(DateTime.Now.Month)) - (Database.GetRedZone(DateTime.Now.Month))))
                    {
                        MessageBox.Show("Please be alterted that your monthly Red Zone has been reached.");
                    }
                }
                this.Close();
            }
        }

        private void UpdateTheme()
        {
            Label[] lables = new[] { label1, label2, label3, label4, label5, label6 };
            CheckBox[] checkBoxes = new[] { cbExpense, cbIncome, cbWeekly, cbMonthly };
            int theme = Database.GetThemeIndex();
            Colors colorTheme = new Colors(theme);
            this.BackColor = colorTheme.Background;

            foreach (var item in lables)
            {
                item.ForeColor = colorTheme.Text;
            }
            foreach(var item in checkBoxes)
            {
                item.ForeColor = colorTheme.Text;
            }

            btnSave.ForeColor = colorTheme.Text2;
            btnSave.BackColor = colorTheme.ButtonAndSelectedBack;
            btnCancel.ForeColor = colorTheme.Text2;
            btnCancel.BackColor = colorTheme.ButtonAndSelectedBack;

            cbNewTransactionCategory.ForeColor = colorTheme.Text2;
            cbNewTransactionCategory.BackColor = colorTheme.TextBoxBack;
            txtNewTransactionDescription.ForeColor = colorTheme.Text2;
            txtNewTransactionDescription.BackColor = colorTheme.TextBoxBack;
            nudNewTransactionAmount.ForeColor = colorTheme.Text2;
            nudNewTransactionAmount.BackColor = colorTheme.TextBoxBack;
        }
    }
}
