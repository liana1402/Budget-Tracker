using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BudgetTracker
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            UpdateTheme();

            //set current balance
            txtCurrentBalance.Text = Database.GetCurrentBalance().ToString("c");
            //set week number
            lblWeekNumber.Text = Database.GetWeek(DateTime.Now).ToString();

            //add any repeated transactions
            List<Transaction> repeatedTransactionsList = Database.GetTransactions(DateTime.Now.Month, "2");
            int month = DateTime.Now.Month - 1;
            if(month == 0) month = 12;
            foreach(Transaction item in Database.GetTransactions(month, "3"))
            {
                repeatedTransactionsList.Add(item);
            }
            foreach (Transaction transaction in repeatedTransactionsList)
            {
                bool add = false;
                if (transaction.Status.ToString() == "weekly" && transaction.Date.Day == DateTime.Now.Day)
                {
                    if (transaction.Date.DayOfWeek == DateTime.Now.DayOfWeek && transaction.Repeated == false)
                    {
                        add = true;
                    }
                }
                else if(transaction.Status.ToString() == "monthly" && transaction.Date.Day == DateTime.Now.Day)
                {
                    if(transaction.Repeated == false)
                    {
                        add = true;
                    }
                }
                if(add == true)
                {
                    float balanceAfterTransaction = (float)Database.GetCurrentBalance() + transaction.Amount;
                    string date = DateTime.Now.ToString("yyyy-MM-dd");
                    Database.AddTransaction(Database.GetCategoryID(transaction.Category), date, transaction.Description, transaction.Amount, "monthly", balanceAfterTransaction);
                    //update existing transaction repeated to true
                    Database.ConnectDatabase();
                    MySqlCommand commandDatabaseUpdateRepeated = new MySqlCommand($"UPDATE transactions SET repeated = 1 WHERE user_id = '{Database.userID}' AND transaction_number = {transaction.Id}", Database.databaseConnection);
                    commandDatabaseUpdateRepeated.ExecuteReader();
                }
            }

            //insert data into transactions table
            UpdateTransactions();
            //insert data into weekly table
            UpdateWeeklyTable();
            //set weekly total
            txtWeeklyTotal.Text = Database.GetWeeklyTotal().ToString("c");
        }

        private void btnRemoveTransaction_Click(object sender, EventArgs e)
        {
            if(dgvTransactionsList.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                var selectedTransactionAmount = dgvTransactionsList.SelectedRows[0].Cells[4].Value;
                float currentBalance = Database.GetCurrentBalance();
                var selectedTransactionId = dgvTransactionsList.SelectedRows[0].Cells[0].Value;
                DateTime selectedTransactionDate = (DateTime)dgvTransactionsList.SelectedRows[0].Cells[1].Value;
                string date = selectedTransactionDate.ToString("yyyy-MM-dd");

                //update balance after transaction of after that transactions date
                Database.ConnectDatabase();
                MySqlCommand commandDatabaseUpdateTransactions = new MySqlCommand($"UPDATE transactions SET balance_after_transaction = balance_after_transaction - {selectedTransactionAmount} WHERE user_id = {Database.userID} AND transaction_date >= '{date}'", Database.databaseConnection);
                commandDatabaseUpdateTransactions.ExecuteReader();
                Database.databaseConnection.Close();

                //delete transaction
                Database.ConnectDatabase();
                MySqlCommand commandDatabaseRemoveTransaction = new MySqlCommand($"DELETE FROM transactions WHERE user_id = {Database.userID} AND transaction_number = {selectedTransactionId}; UPDATE account SET current_balance = {currentBalance - (float)selectedTransactionAmount} WHERE user_id = {Database.userID}", Database.databaseConnection);
                commandDatabaseRemoveTransaction.ExecuteReader();
                Database.databaseConnection.Close();

                UpdateTransactions();
                txtCurrentBalance.Text = Database.GetCurrentBalance().ToString("c");
                txtWeeklyTotal.Text = Database.GetWeeklyTotal().ToString("c");
                UpdateWeeklyTable();
            }
        }

        private void btnOpenAddTransaction_Click(object sender, EventArgs e)
        {
            if(Database.GetMonthlyBudget(DateTime.Now.Month) == 0)
            {
                MessageBox.Show("Please enter a monthly budget from the settings before adding a transaction.");
            }
            else
            {
                AddTransaction addTransaction = new AddTransaction();
                addTransaction.ShowDialog();
                UpdateTransactions();
                txtCurrentBalance.Text = Database.GetCurrentBalance().ToString("c");
                txtWeeklyTotal.Text = Database.GetWeeklyTotal().ToString("c");
                UpdateWeeklyTable();
            }
        }

        private void btnOpenMonthlyRecord_Click(object sender, EventArgs e)
        {
            MonthlyRecord monthlyRecord = new MonthlyRecord();
            monthlyRecord.ShowDialog();
        }

        private void btnOpenMyCategories_Click(object sender, EventArgs e)
        {
            if (Database.GetMonthlyBudget(DateTime.Now.Month) == 0)
            {
                MessageBox.Show("Please enter a monthly budget from the settings before adding a transaction.");
            }
            else
            {
                MyCategories myCategories = new MyCategories();
                myCategories.ShowDialog();
                UpdateTransactions();
                UpdateWeeklyTable();
            }
        }

        private void btnOpenHelp_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }

        private void btnOpenSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
            UpdateTheme();
        }

        private void UpdateTransactions()
        {
            List<Transaction> transactionsList = Database.GetTransactions(DateTime.Now.Month, "none");
            transactionsList.Sort((x, y) => DateTime.Compare(x.Date, y.Date));
            dgvTransactionsList.DataSource = transactionsList;
            dgvTransactionsList.Columns["Date"].Width = 110;
            dgvTransactionsList.Columns["Category"].Width = 140;
            dgvTransactionsList.Columns["Description"].Width = 190;
            dgvTransactionsList.Columns["Amount"].Width = 110;
            dgvTransactionsList.Columns["Amount"].DefaultCellStyle.Format = "c";
            dgvTransactionsList.Columns["Balance"].Width = 110;
            dgvTransactionsList.Columns["Balance"].DefaultCellStyle.Format = "c";
            dgvTransactionsList.Columns["Id"].Visible = false;
            dgvTransactionsList.Columns["Status"].Visible = false;
            dgvTransactionsList.Columns["Repeated"].Visible = false;
        }

        private void UpdateWeeklyTable()
        {
            string period = "weekly";
            List<Categories> categoriesList = Database.GetCategories(period, DateTime.Now);
            dgvWeeklyCategoryTotals.DataSource = categoriesList;
            dgvWeeklyCategoryTotals.Columns["Amount"].DefaultCellStyle.Format = "c";
            dgvWeeklyCategoryTotals.Columns["Budget"].DefaultCellStyle.Format = "c";
        }

        private void UpdateTheme()
        {
            System.Windows.Forms.Label[] lables = new[] { lblCurrentBalance, lblWeeklyTotal, lblWeeklyTotal, lblWeekNumber, lblWeek };
            System.Windows.Forms.Button[] buttons = new[] { btnOpenAddTransaction, btnOpenMonthlyRecord, btnOpenMyCategories, btnOpenHelp, btnOpenSettings, btnRemoveTransaction };
            System.Windows.Forms.DataGridView[] dgv = new[] { dgvTransactionsList, dgvWeeklyCategoryTotals };
            int theme = Database.GetThemeIndex();
            Colors colorTheme = new Colors(theme);
            this.BackColor = colorTheme.Background;

            txtCurrentBalance.BackColor = colorTheme.TextBoxBack;
            txtWeeklyTotal.BackColor = colorTheme.TextBoxBack;
            txtCurrentBalance.ForeColor = colorTheme.Text2;
            txtWeeklyTotal.ForeColor = colorTheme.Text2;

            foreach(var item in lables)
            {
                item.ForeColor = colorTheme.Text;
            }
            foreach(var item in buttons)
            {
                item.ForeColor = colorTheme.Text2;
                item.BackColor = colorTheme.ButtonAndSelectedBack;
            }
            foreach(var item in dgv)
            {
                item.DefaultCellStyle.SelectionBackColor = colorTheme.ButtonAndSelectedBack;
                item.DefaultCellStyle.BackColor = colorTheme.TableBack;
                item.DefaultCellStyle.ForeColor = colorTheme.Text2;
                item.DefaultCellStyle.SelectionForeColor = colorTheme.Text;
                item.BackgroundColor = colorTheme.TableBack;
                item.ColumnHeadersDefaultCellStyle.BackColor = colorTheme.TableBack;
                item.ColumnHeadersDefaultCellStyle.ForeColor = colorTheme.Text2;
                item.ColumnHeadersDefaultCellStyle.SelectionBackColor = colorTheme.TableBack;
                item.GridColor = colorTheme.Grid;
            }
        }
    }
}
