using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static BudgetTracker.Transaction;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BudgetTracker
{
    public static class Database
    {
        public static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=budgettrackerdb;";
        public static MySqlConnection databaseConnection;
        public static int userID;

        //connect and open database 
        public static void ConnectDatabase()
        {
            databaseConnection = new MySqlConnection(connectionString);
            databaseConnection.Open();
        }

        //account functions
        //get and set userID
        public static int SetUserID(string username)
        {
            Database.ConnectDatabase();
            MySqlCommand commandDatabaseGetID = new MySqlCommand($"SELECT user_id FROM account WHERE username = '{username}'", Database.databaseConnection);
            MySqlDataReader readerGetID = commandDatabaseGetID.ExecuteReader();
            while (readerGetID.Read())
            {
                userID = readerGetID.GetInt32(0);
            }
            Database.databaseConnection.Close();
            return userID;
        }

        //get username 
        public static string GetUsername()
        {
            Database.ConnectDatabase();
            string username = default;
            MySqlCommand commandDatabaseGetUsername = new MySqlCommand($"SELECT username FROM account WHERE user_id = '{userID}'", databaseConnection);
            MySqlDataReader readerGetUsername = commandDatabaseGetUsername.ExecuteReader();

            while (readerGetUsername.Read())
            {
                username = readerGetUsername.GetString(0);
            }
            Database.databaseConnection.Close();
            return username;
        }

        //get current balance
        public static float GetCurrentBalance()
        {
            Database.ConnectDatabase();
            float currentBalance = default;
            MySqlCommand commandDatabaseGetCurrentBalance = new MySqlCommand($"SELECT current_balance FROM account WHERE user_id = '{userID}'", databaseConnection);
            MySqlDataReader readerGetCurrentBalance = commandDatabaseGetCurrentBalance.ExecuteReader();

            while (readerGetCurrentBalance.Read())
            {
                currentBalance = readerGetCurrentBalance.GetFloat(0);
            }
            Database.databaseConnection.Close();
            return currentBalance;
        }

        //get theme
        public static int GetThemeIndex()
        {
            int index = default;
            string theme = default;
            Database.ConnectDatabase();
            MySqlCommand commandDatabaseGetTheme = new MySqlCommand($"SELECT display_theme FROM account WHERE user_id = '{userID}'", databaseConnection);
            MySqlDataReader readerGetTheme = commandDatabaseGetTheme.ExecuteReader();

            while (readerGetTheme.Read())
            {
                theme = readerGetTheme.GetString(0);
            }

            if (theme == "default")
            {
                index = 0;
            }
            else if (theme == "dark")
            {
                index = 1;
            }
            else if (theme == "dark_neutral")
            {
                index = 2;
            }

            Database.databaseConnection.Close();
            return index;
        }

        //check username exists
        public static bool CheckUsername(string username)
        {
            bool accountExists = default;
            Database.ConnectDatabase();
            MySqlCommand commandDatabaseCheck = new MySqlCommand($"SELECT COUNT(username) FROM account WHERE username = '{username}'", Database.databaseConnection);
            MySqlDataReader readerCheck = commandDatabaseCheck.ExecuteReader();

            while (readerCheck.Read())
            {
                accountExists = readerCheck.GetBoolean(0);
            }
            Database.databaseConnection.Close();
            return accountExists;
        }

        //category functions
        //get category names
        public static List<string> GetCategoryNames()
        {
            List<string> categories = new List<string>();
            Database.ConnectDatabase();
            MySqlCommand commandDatabaseGetCategories = new MySqlCommand($"SELECT category_name FROM category WHERE user_id = '{Database.userID}'", Database.databaseConnection);
            MySqlDataReader readerGetCategories = commandDatabaseGetCategories.ExecuteReader();

            while (readerGetCategories.Read())
            {
                categories.Add(readerGetCategories.GetString(0));
            }
            Database.databaseConnection.Close();
            return categories;
        }

        //get category info with amount
        public static List<Categories> GetCategories(string period, DateTime dateOfInfo)
        {
            List<Categories> categories = new List<Categories>(); //list of categories to return
            List<int> transactions = new List<int>(); //list of transactions to use

            //first add transaction IDs to transactions list
            Database.ConnectDatabase();
            MySqlCommand commandDatabaseGetTransaction = new MySqlCommand($"SELECT transaction_number, transaction_date FROM transactions WHERE transactions.user_id = '{userID}'", databaseConnection);
            MySqlDataReader readerGetTransaction = commandDatabaseGetTransaction.ExecuteReader();

            if (period == "weekly")
            {
                try
                {
                    while (readerGetTransaction.Read())
                    {
                        DateTime date = readerGetTransaction.GetDateTime("transaction_date");
                        if (GetWeek(date) == GetWeek(dateOfInfo) && date.Month == dateOfInfo.Month)
                        {
                            transactions.Add(readerGetTransaction.GetInt32("transaction_number"));
                        }
                    }
                    Database.databaseConnection.Close();
                }
                catch
                {

                }
            }
            else if (period == "monthly")
            {
                try
                {
                    while (readerGetTransaction.Read())
                    {
                        DateTime date = readerGetTransaction.GetDateTime("transaction_date");
                        if (date.Month == dateOfInfo.Month)
                        {
                            transactions.Add(readerGetTransaction.GetInt32("transaction_number"));
                        }
                    }
                    Database.databaseConnection.Close();
                }
                catch
                {

                }
                Database.databaseConnection.Close();
            }

            //second get the category info for each transaction and add it to the categories list
            foreach (int transactionNum in transactions)
            {
                string name = default;
                float amount = 0;
                float budget = 0;
                Database.ConnectDatabase();
                MySqlCommand commandDatabaseGetCategories = new MySqlCommand($"SELECT category_name, category_budget, amount FROM category INNER JOIN categorybudget ON category.category_id = categorybudget.category_id INNER JOIN transactions ON categorybudget.category_id = transactions.category_id WHERE transactions.user_id = {userID} AND transactions.transaction_number = {transactionNum}", databaseConnection);
                MySqlDataReader readerGetCategories = commandDatabaseGetCategories.ExecuteReader();

                while (readerGetCategories.Read())
                {
                    name = readerGetCategories.GetString("category_name");
                    amount = readerGetCategories.GetFloat("amount");
                    budget = readerGetCategories.GetFloat("category_budget");
                }
                Database.databaseConnection.Close();

                //check if category already exists in the list. if so, add the amount onto it and if not, create a new object and add
                bool exists = false;
                foreach (Categories cat in categories)
                {
                    if (cat.Category == name)
                    {
                        cat.Amount += amount;
                        exists = true;
                    }
                }
                if (exists == false)
                {
                    Categories category = new Categories(name, amount, budget);
                    categories.Add(category);
                }
            }
            return categories;
        }

        //get category info without amount
        public static List<Categories> GetCategories()
        {
            List<Categories> categories = new List<Categories>();
            Database.ConnectDatabase();
            MySqlCommand commandDatabaseGetCategories = new MySqlCommand($"SELECT category_name, category_budget FROM category INNER JOIN categorybudget ON category.category_id = categorybudget.category_id WHERE category.user_id = '{userID}'", databaseConnection);
            MySqlDataReader readerGetCategories = commandDatabaseGetCategories.ExecuteReader();

            while (readerGetCategories.Read())
            {
                string name = readerGetCategories.GetString("category_name");
                float budget = readerGetCategories.GetFloat("category_budget");
                Categories category = new Categories(name, budget);
                categories.Add(category);
            }
            Database.databaseConnection.Close();

            return categories;
        }

        //get category id
        public static int GetCategoryID(string categoryName)
        {
            int categoryID = default;
            Database.ConnectDatabase();
            MySqlCommand commandDatabaseGetCategories = new MySqlCommand($"SELECT category_id FROM category WHERE user_id = '{Database.userID}' AND category_name = '{categoryName}'", Database.databaseConnection);
            MySqlDataReader readerGetCategories = commandDatabaseGetCategories.ExecuteReader();

            while (readerGetCategories.Read())
            {
                categoryID = readerGetCategories.GetInt32(0);
            }
            Database.databaseConnection.Close();
            return categoryID;
        }

        //add category
        public static void AddCategory(string name)
        {
            //add category
            Database.ConnectDatabase();
            MySqlCommand commandDatabaseAddCategory = new MySqlCommand($"INSERT INTO category(user_id, category_name) VALUES({userID}, '{name.Trim()}')", databaseConnection);
            commandDatabaseAddCategory.ExecuteReader();
            Database.databaseConnection.Close();

            //add category budget
            int budgetID = GetMonthlyBudgetID(DateTime.Now.Month);
            int categoryID = GetCategoryID(name);
            Database.ConnectDatabase();
            MySqlCommand commandDatabaseAddCategoryBudget = new MySqlCommand($"INSERT INTO categorybudget (monthly_budget_id, category_id, category_budget) VALUES({budgetID},{categoryID},0)", databaseConnection);
            commandDatabaseAddCategoryBudget.ExecuteReader();
            Database.databaseConnection.Close();
        }

        //monthly budget functions
        //get monthly budget
        public static float GetMonthlyBudget(int month)
        {
            float monthlyBudget = default;
            int budgetID = GetMonthlyBudgetID(month);

            Database.ConnectDatabase();
            MySqlCommand commandDatabaseGetMonthlyBudget = new MySqlCommand($"SELECT month_budget FROM monthlybudget WHERE user_id = '{userID}' AND monthly_budget_id = '{budgetID}'", databaseConnection);
            MySqlDataReader readerGetMonthlyBudget = commandDatabaseGetMonthlyBudget.ExecuteReader();

            while (readerGetMonthlyBudget.Read())
            {
                monthlyBudget = readerGetMonthlyBudget.GetFloat(0);
            }
            Database.databaseConnection.Close();
            return monthlyBudget;
        }

        //get monthly budget id
        public static int GetMonthlyBudgetID(int month)
        {
            int monthlyBudgetID = default;

            Database.ConnectDatabase();
            MySqlCommand commandDatabaseGetBudgetID = new MySqlCommand($"SELECT monthly_budget_id FROM monthlybudget WHERE user_id = '{Database.userID}' AND month = '{month}'", Database.databaseConnection);
            MySqlDataReader readerGetBudgetID = commandDatabaseGetBudgetID.ExecuteReader();

            while (readerGetBudgetID.Read())
            {
                monthlyBudgetID = readerGetBudgetID.GetInt32(0);
            }
            Database.databaseConnection.Close();
            return monthlyBudgetID;
        }

        //get red zone
        public static float GetRedZone(int month)
        {
            float redZone = default;

            Database.ConnectDatabase();
            MySqlCommand commandDatabaseGetRedZone = new MySqlCommand($"SELECT red_zone FROM monthlybudget WHERE user_id = '{userID}' AND month = '{month}'", databaseConnection);
            MySqlDataReader readerGetRedZone = commandDatabaseGetRedZone.ExecuteReader();

            while (readerGetRedZone.Read())
            {
                redZone = readerGetRedZone.GetFloat(0);
            }
            Database.databaseConnection.Close();

            return redZone;
        }

        //transaction functions
        //add new transaction
        public static void AddTransaction(int categoryID, string date, string description, float amount, string repeatedStatus, float balance)
        {
            Database.ConnectDatabase();
            MySqlCommand commandDatabaseAddTransaction = new MySqlCommand($"INSERT INTO transactions(user_id, category_id, transaction_date, description, amount, repeated_status, balance_after_transaction) VALUES({userID},{categoryID},'{date}','{description}',{amount},'{repeatedStatus}',{balance}); UPDATE account SET current_balance = {balance} WHERE user_id = {userID}", databaseConnection);
            commandDatabaseAddTransaction.ExecuteReader();
            Database.databaseConnection.Close();
        }

        //get transactions info
        public static List<Transaction> GetTransactions(int month, string condition)
        {
            List<Transaction> transactionsList = new List<Transaction>();
            if(condition == "none")
            {
                condition = $"ANY (SELECT repeated_status FROM transactions WHERE user_id = {userID})";
            }

            Database.ConnectDatabase();
            var statement = $"SELECT transaction_number,transaction_date,category_name,description,amount,repeated_status-1,balance_after_transaction,repeated" +
                            $"FROM transactions" +
                            $"INNER JOIN category ON transactions.category_id = category.category_id" +
                            $"WHERE transactions.user_id = {userID} AND MONTH(transactions.transaction_date) = {month} AND transactions.repeated_status = {condition}";

            MySqlCommand commandDatabaseGetTransactions = new MySqlCommand($"SELECT transaction_number,transaction_date,category_name,description,amount,repeated_status-1,balance_after_transaction,repeated FROM transactions INNER JOIN category ON transactions.category_id = category.category_id WHERE transactions.user_id = {userID} AND MONTH(transactions.transaction_date) = {month} AND transactions.repeated_status = {condition}", databaseConnection);
            MySqlDataReader readerGetTransactions = commandDatabaseGetTransactions.ExecuteReader();

            while (readerGetTransactions.Read())
            {
                int id = readerGetTransactions.GetInt32("transaction_number");
                DateTime transaction_date = readerGetTransactions.GetDateTime("transaction_date");
                string category = readerGetTransactions.GetString("category_name");
                string description = readerGetTransactions.GetString("description");
                float amount = readerGetTransactions.GetFloat("amount");
                int repeatedStatus = readerGetTransactions.GetInt32("repeated_status-1");
                float balanceAfterTransaction = readerGetTransactions.GetFloat("balance_after_transaction");
                bool repeated = readerGetTransactions.GetBoolean("repeated");
                Transaction transaction = new Transaction(id, transaction_date, category, description, amount, balanceAfterTransaction, repeatedStatus, repeated);
                transactionsList.Add(transaction);
            }
            Database.databaseConnection.Close();

            return transactionsList;
        }

        //get weekly total
        public static float GetWeeklyTotal()
        {
            float weeklyTotal = 0;
            float amount;
            DateTime date;
            Database.ConnectDatabase();
            MySqlCommand commandDatabaseGetCategories = new MySqlCommand($"SELECT amount, transaction_date FROM transactions WHERE user_id = '{userID}'", databaseConnection);
            MySqlDataReader readerGetCategories = commandDatabaseGetCategories.ExecuteReader();

            while (readerGetCategories.Read())
            {
                amount = readerGetCategories.GetFloat("amount");
                date = readerGetCategories.GetDateTime("transaction_date");
                if (GetWeek(date) == GetWeek(DateTime.Now) && date.Month == DateTime.Now.Month)
                {
                    weeklyTotal = weeklyTotal + amount;
                }
            }
            Database.databaseConnection.Close();

            return weeklyTotal;
        }

        //get incomes
        public static float GetMonthlyIncome(int month)
        {
            float incomes = 0;
            Database.ConnectDatabase();
            MySqlCommand commandDatabaseGetIncome = new MySqlCommand($"SELECT amount, transaction_date FROM transactions WHERE user_id = '{userID}'", databaseConnection);
            MySqlDataReader readerGetIncome = commandDatabaseGetIncome.ExecuteReader();

            while (readerGetIncome.Read())
            {
                DateTime date = readerGetIncome.GetDateTime(1);
                if (readerGetIncome.GetFloat(0) > 0 && date.Month == month)
                {
                    incomes += readerGetIncome.GetFloat(0);
                }
            }
            Database.databaseConnection.Close();
            return incomes;
        }

        //get expenses
        public static float GetMonthlyExpense(int month)
        {
            float expenses = 0;
            Database.ConnectDatabase();
            MySqlCommand commandDatabaseGetExpense = new MySqlCommand($"SELECT amount, transaction_date FROM transactions WHERE user_id = '{userID}'", databaseConnection);
            MySqlDataReader readerGetExpense = commandDatabaseGetExpense.ExecuteReader();

            while (readerGetExpense.Read())
            {
                DateTime date = readerGetExpense.GetDateTime(1);
                if (readerGetExpense.GetFloat(0) < 0 && date.Month == month)
                {
                    expenses += readerGetExpense.GetFloat(0);
                }
            }
            Database.databaseConnection.Close();
            return expenses;
        }

        //other functions
        //get week
        public static int GetWeek(DateTime date)
        {
            int week = date.Day / 7 + 1;
            return (week);
        }

        //check special characters
        public static bool CheckChars(string text)
        {
            bool passed = true;
            char[] letters = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm0123456789".ToCharArray();
            foreach (char letter in text)
            {
                if (!letters.Contains(letter))
                {
                    passed = false;
                }
            }
            return passed;
        }
    }
}
