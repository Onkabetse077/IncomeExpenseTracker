using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IncomeExpenseTracker
{
    internal class ExpenseData
    {
        string connection =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\gosia\Documents\Projects\Visual Studio\C#\IncomeExpenseTracker\tools\Databases\expense.mdf"";Integrated Security=True;Connect Timeout=30";
        public int ID { set; get; }
        public string Category { set; get; }
        public string Item { set; get; }
        public string Expense { set; get; }
        public string Description { set; get; }
        public string Date_Expense { set; get; }


        public List<ExpenseData> expenseListData()
        {
            List<ExpenseData> listData = new List<ExpenseData>();

            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectData = "SELECT * FROM expense";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ExpenseData expenseData = new ExpenseData();

                        expenseData.ID = (int)reader["id"];
                        expenseData.Category = reader["category"].ToString();
                        expenseData.Item = reader["item"].ToString();
                        expenseData.Expense = reader["expense"].ToString();
                        expenseData.Description = reader["description"].ToString();
                        expenseData.Date_Expense = ((DateTime)reader["date_expense"]).ToString("dd/MMM/yyyy");
                        listData.Add(expenseData);
                    }

                }
            }

            return listData;
        }
    }
}
