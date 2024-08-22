using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IncomeExpenseTracker
{
    internal class IncomeData
    {
        string connection =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\gosia\Documents\Projects\Visual Studio\C#\IncomeExpenseTracker\tools\Databases\expense.mdf"";Integrated Security=True;Connect Timeout=30";

        public int ID { set; get; }
        public string Category { set; get; }
        public string Item { set; get; }
        public string Income { set; get; }
        public string Description { set; get; }
        public string Date_Income { set; get; }
        public string Date_Inserted { set; get; }


        public List<IncomeData> incomeListData()
        {
            List<IncomeData> listData = new List<IncomeData>();

            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectData = "SELECT * FROM income";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        IncomeData incomeData = new IncomeData();

                        incomeData.ID = (int)reader["id"];
                        incomeData.Category = reader["category"].ToString();
                        incomeData.Item = reader["item"].ToString();
                        incomeData.Income = reader["income"].ToString();
                        incomeData.Description = reader["description"].ToString();
                        incomeData.Date_Income = ((DateTime)reader["date_income"]).ToString("dd/MMM/yyyy");
                        incomeData.Date_Inserted = ((DateTime)reader["date_inserted"]).ToString("dd/MMM/yyyy");

                        listData.Add(incomeData);
                    }

                }
            }

            return listData;
        }

    }
}
