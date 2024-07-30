using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    public class Transaction
    {
        private int id;
        private DateTime date;
        private string category;
        private string description;
        private float amount;
        private float balance;
        public enum RepeatedStatus { not, weekly, monthly }
        private RepeatedStatus status;
        private bool repeated;

        public Transaction(int id, DateTime date, string category, string description, float amount, float balance, int repeatedStatus, bool repeated)
        {
            this.Id = id;
            this.Date = date;
            this.Category = category;
            this.Description = description;
            this.Amount = amount;
            this.Balance = balance;

            if (repeatedStatus == 1)
            {
                this.Status = RepeatedStatus.weekly;
            }
            else if(repeatedStatus == 2)
            {
                this.Status = RepeatedStatus.monthly;
            }
            else
            {
                this.Status = RepeatedStatus.not;
            }
            this.Repeated = repeated;
        }

        //get/set
        public int Id { get { return id; } set { id = value; } }
        public DateTime Date { get { return date; } set {  date = value; } }
        public string Category { get { return category; } set { category = value; } }
        public string Description { get { return description; } set { description = value; } }
        public float Amount { get { return amount; } set { amount = value; } }
        public float Balance { get { return balance; } set { balance = value; } }
        public RepeatedStatus Status { get { return status; } set {  status = value; } }
        public bool Repeated { get { return repeated; } set {  repeated = value; } }
    }
}
