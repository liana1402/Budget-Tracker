using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BudgetTracker
{
    public class Colors
    {
        //font colour
        public Color Text;
        public Color Text2;
        //backgrounds
        public Color Background;
        public Color ButtonAndSelectedBack;
        public Color TableBack;
        public Color TextBoxBack;
        //border / grid
        public Color Grid;

        public Colors(int theme)
        {
            if(theme == 0) //default
            {
                Text = Color.Black;
                Text2 = Color.Black;
                Background = Color.FromArgb(255, 243, 235);
                ButtonAndSelectedBack = Color.FromArgb(210, 210, 198);
                TableBack = Color.FromArgb(221, 190, 169);
                TextBoxBack = Color.FromArgb(255, 232, 214);
                Grid = Color.FromArgb(239, 241, 237);
            }
            else if (theme == 1) //dark
            {
                Text = Color.FromArgb(239, 241, 237);
                Text2 = Color.FromArgb(239, 241, 237);
                Background = Color.FromArgb(0, 41, 61);
                ButtonAndSelectedBack = Color.FromArgb(0, 68, 102);
                TableBack = Color.FromArgb(0, 34, 51);
                TextBoxBack = Color.FromArgb(0, 38, 56);
                Grid = Color.FromArgb(0, 82, 122);
            }
            else if (theme == 2) //dark neutral
            {
                Text = Color.FromArgb(239, 241, 237);
                Text2 = Color.Black;
                Background = Color.FromArgb(82, 121, 111);
                ButtonAndSelectedBack = Color.FromArgb(107, 145, 126);
                TableBack = Color.FromArgb(181, 193, 174);
                TextBoxBack = Color.FromArgb(132, 169, 140);
                Grid = Color.FromArgb(53, 79, 82);
            }
        }
    }
}
