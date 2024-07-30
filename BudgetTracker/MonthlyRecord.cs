using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTracker
{
    public partial class MonthlyRecord : Form
    {
        DateTime dateForChart = DateTime.Now;
        public MonthlyRecord()
        {
            InitializeComponent();
            UpdateTheme();

            //set selected month and list
            cbSelectedMonth.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Now.Month);
            for (int i = 0; i < 12; i++)
            {
                cbSelectedMonth.Items.Add(DateTimeFormatInfo.CurrentInfo.MonthNames[i]);
            }
            UpdateRecord(DateTime.Now, DateTime.Now.Month);
        }

        private void cbSelectedMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int month = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList().IndexOf(cbSelectedMonth.Text) + 1;
            DateTime date = new DateTime(DateTime.Now.Year, month, 1);
            dateForChart = date;
            UpdateRecord(date, month);
        }

        private void btnViewChart_Click(object sender, EventArgs e)
        {
            Chart chart = new Chart(dateForChart);
            chart.ShowDialog();
        }

        private void UpdateRecord(DateTime date, int month)
        {
            List<Categories> categoriesList = Database.GetCategories("monthly", date);
            dgvWeeklyCategoryTotals.DataSource = categoriesList;
            dgvWeeklyCategoryTotals.Columns["Amount"].DefaultCellStyle.Format = "c";
            dgvWeeklyCategoryTotals.Columns["Budget"].DefaultCellStyle.Format = "c";

            //set total income, total expense, total profit, and monthly budget
            float incomes = Database.GetMonthlyIncome(month);
            float expenses = Database.GetMonthlyExpense(month);

            txtBudgetOfMonth.Text = Database.GetMonthlyBudget(month).ToString("c");
            txtTotalIncome.Text = incomes.ToString("c");
            txtTotalExpense.Text = expenses.ToString("c");
            txtTotalProfit.Text = (incomes + expenses).ToString("c");
        }

        private void UpdateTheme()
        {
            System.Windows.Forms.TextBox[] textboxes = new[] { txtBudgetOfMonth, txtTotalExpense, txtTotalIncome, txtTotalProfit };
            System.Windows.Forms.Label[] lables = new[] { label1, label2, label3, label4, label5, label6 };
            int theme = Database.GetThemeIndex();
            Colors colorTheme = new Colors(theme);
            this.BackColor = colorTheme.Background;

            foreach(var item in lables)
            {
                item.ForeColor = colorTheme.Text;
            }
            foreach(var item in textboxes)
            {
                item.BackColor = colorTheme.TextBoxBack;
                item.ForeColor = colorTheme.Text2;
            }
            cbSelectedMonth.BackColor = colorTheme.ButtonAndSelectedBack;
            cbSelectedMonth.ForeColor = colorTheme.Text2;

            btnViewChart.BackColor = colorTheme.ButtonAndSelectedBack;
            btnViewChart.ForeColor = colorTheme.Text2;

            dgvWeeklyCategoryTotals.DefaultCellStyle.SelectionBackColor = colorTheme.ButtonAndSelectedBack;
            dgvWeeklyCategoryTotals.DefaultCellStyle.SelectionForeColor = colorTheme.Text;
            dgvWeeklyCategoryTotals.DefaultCellStyle.BackColor = colorTheme.TableBack;
            dgvWeeklyCategoryTotals.DefaultCellStyle.ForeColor = colorTheme.Text2;
            dgvWeeklyCategoryTotals.BackgroundColor = colorTheme.TableBack;
            dgvWeeklyCategoryTotals.ColumnHeadersDefaultCellStyle.BackColor = colorTheme.TableBack;
            dgvWeeklyCategoryTotals.ColumnHeadersDefaultCellStyle.ForeColor = colorTheme.Text2;
            dgvWeeklyCategoryTotals.ColumnHeadersDefaultCellStyle.SelectionBackColor = colorTheme.TableBack;
            dgvWeeklyCategoryTotals.GridColor = colorTheme.Grid;
        }
    }
}
