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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            int theme = Database.GetThemeIndex();
            Colors colorTheme = new Colors(theme);
            this.BackColor = colorTheme.TableBack;
            System.Windows.Forms.Label[] lables = new Label[] { lblTitle, label1, label2, label3, label4 };
            foreach(Label item in lables)
            {
                item.ForeColor = colorTheme.Text2;
            }
        }
    }
}
