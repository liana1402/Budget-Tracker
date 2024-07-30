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
    public partial class MyCategories : Form
    {
        public MyCategories()
        {
            InitializeComponent();
            UpdateTheme();
            UpdateCategories();
        }

        private void btnRemoveSelectedCategory_Click(object sender, EventArgs e)
        {
            if (lbCurrentCategories.SelectedItems.Count == 0)
            {
                return;
            }
            else
            {
                RemoveCategory remove = new RemoveCategory(lbCurrentCategories.Text);
                remove.ShowDialog();
                UpdateCategories();
            }
        }

        private void lbCurrentCategories_DoubleClick(object sender, EventArgs e)
        {
            if(lbCurrentCategories.Text != "")
            {
                EditCategory edit = new EditCategory(lbCurrentCategories.Text);
                edit.ShowDialog();
                UpdateCategories();
            }
        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            AddCategory();
        }

        private void txtAddCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) AddCategory();
        }

        private void AddCategory()
        {
            if (txtAddCategory.Text != "")
            {
                bool exists = false;
                foreach(string cat in lbCurrentCategories.Items)
                {
                    if (cat == txtAddCategory.Text.Trim()) exists = true;
                }

                if(exists == false)
                {
                    bool isLetter = Database.CheckChars(txtAddCategory.Text.Trim());
                    if(isLetter == true)
                    {
                        Database.AddCategory(txtAddCategory.Text.Trim());
                        UpdateCategories();
                    }
                    else
                    {
                        MessageBox.Show("Please use valid characters.");
                    }
                }
                else
                {
                    MessageBox.Show("This category already exists.");
                }
            }
            else
            {
                MessageBox.Show("Please insert the category name into the text box.");
            }
        }

        private void UpdateCategories()
        {
            lbCurrentCategories.Items.Clear();
            List<string> categories = Database.GetCategoryNames();
            foreach(string category in categories)
            {
                lbCurrentCategories.Items.Add(category);
            }
            txtAddCategory.Text = "";
        }

        private void UpdateTheme()
        {
            int theme = Database.GetThemeIndex();
            Colors colorTheme = new Colors(theme);
            this.BackColor = colorTheme.Background;

            label1.ForeColor = colorTheme.Text;
            label2.ForeColor = colorTheme.Text;

            lbCurrentCategories.BackColor = colorTheme.TableBack;
            lbCurrentCategories.ForeColor = colorTheme.Text2;

            txtAddCategory.ForeColor = colorTheme.Text2;
            txtAddCategory.BackColor = colorTheme.TextBoxBack;

            btnAddNewCategory.ForeColor = colorTheme.Text2;
            btnAddNewCategory.BackColor = colorTheme.ButtonAndSelectedBack;
            btnRemoveSelectedCategory.ForeColor = colorTheme.Text2;
            btnRemoveSelectedCategory.BackColor = colorTheme.ButtonAndSelectedBack;
        }
    }
}
