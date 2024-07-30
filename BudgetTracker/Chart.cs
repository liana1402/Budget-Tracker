using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BudgetTracker
{
    public partial class Chart : Form
    {
        public Chart(DateTime date)
        {
            InitializeComponent();
            UpdateTheme();

            //set selected month and list
            cbSelectedMonth.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(date.Month);
            for (int i = 0; i < 12; i++)
            {
                cbSelectedMonth.Items.Add(DateTimeFormatInfo.CurrentInfo.MonthNames[i]);
            }
            UpdateChart(date);
        }

        private void cbSelectedMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int month = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList().IndexOf(cbSelectedMonth.Text) + 1;
            DateTime date = new DateTime(DateTime.Now.Year, month, 1);
            UpdateChart(date);
        }

        private void UpdateChart(DateTime date)
        {
            List<Categories> categories = Database.GetCategories("monthly", date);
            TextBox[] textBoxes = new []{ textBox1, textBox2, textBox3, textBox4, textBox5, textBox6 };
            Label[] labels = new[] { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12 };

            //reset chart
            foreach (TextBox tb in textBoxes)
            {
                Point newLocation = new Point(tb.Location.X, tb.Location.Y + tb.Height);
                tb.Location = newLocation;
                tb.Height = 1;
            }
            for(int i = 0; i < labels.Count(); i++)
            {
                labels[i].Text = "";
            }

            //select and order top 6 categories
            categories = categories.OrderBy(cat => cat.Amount).Take(6).ToList();
            
            //add to chart
            float totalExpenses = Database.GetMonthlyExpense(date.Month);

            for (int i = 0; i < categories.Count; i++)
            {
                if(categories[i].Amount <= 0)
                {
                    //change bar height
                    float percentage = -(categories[i].Amount) / -(totalExpenses); //get the percentage of total expense that is this category amount
                    double height = percentage * 220; //set the height corresponding to the max height of 220
                    textBoxes[i].Height = (int)Math.Floor(height);
                    //change bar location
                    textBoxes[i].Top = 327 - textBoxes[i].Height;
                    //change category label
                    labels[i].Text = categories[i].Category;
                }
            }
        }

        private void barHoverEnter(object sender, EventArgs e)
        {
            int month = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList().IndexOf(cbSelectedMonth.Text) + 1;
            DateTime date = new DateTime(DateTime.Now.Year, month, 1);
            List<Categories> categories = Database.GetCategories("monthly", date);
            Label[] lables = new Label[] { label7, label8, label9, label10, label11, label12 };

            var txt = sender as TextBox;
            int id = Convert.ToInt32(txt.Tag);
            float amount = 0;
            if(id < categories.Count)
            {
                amount = categories[id].Amount;
            }
            if(amount <= 0)
            {
                lables[id].Text = amount.ToString();
            }
        }

        private void barHoverLeave(object sender, EventArgs e)
        {
            Label[] lables = new Label[] { label7, label8, label9, label10, label11, label12 };
            var txt = sender as TextBox;
            int id = Convert.ToInt32(txt.Tag);
            lables[id].Text = "";
        }

        private void UpdateTheme()
        {
            System.Windows.Forms.TextBox[] textBoxes = new[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6 };
            System.Windows.Forms.Label[] labels = new[] { lblCategory, lblExpense, lblShowData, lblTitle, lblTotal, label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12 };
            int theme = Database.GetThemeIndex();
            Colors colorTheme = new Colors(theme);
            this.BackColor = colorTheme.Background;

            cbSelectedMonth.BackColor = colorTheme.ButtonAndSelectedBack;
            cbSelectedMonth.ForeColor = colorTheme.Text2;

            foreach(var item in textBoxes)
            {
                item.BackColor = colorTheme.ButtonAndSelectedBack;
            }
            richTextBox1.BackColor = colorTheme.TableBack;

            foreach(var item in labels)
            {
                item.ForeColor = colorTheme.Text;
            }
        }
    }
}
