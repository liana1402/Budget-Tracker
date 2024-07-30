using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    public class Categories
    {
        private string category;
        private float amount;
        private float budget;

        public Categories(string category, float amount, float budget) 
        {
            this.Category = category;
            this.Amount = amount;
            this.Budget = budget;
        }
        public Categories(string category, float budget)
        {
            this.Category = category;
            this.Budget = budget;
        }

        //get and set
        public string Category { get; set; }
        public float Amount { get; set; }
        public float Budget { get; set; }
    }
}
