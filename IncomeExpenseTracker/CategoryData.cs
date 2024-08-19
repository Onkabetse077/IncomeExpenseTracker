using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IncomeExpenseTracker
{
    class CategoryData
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\gosia\Documents\Projects\Visual Studio\C#\IncomeExpenseTracker\tools\Databases\expense.mdf"";Integrated Security=True;Connect Timeout=30";

        public int ID { set; get; }
        public string Category { set; get; }
        public string Type { set; get; }
        public string Status { set; get; }
        public string date_inserted { set; get; }

        public List<CategoryData> categoryListData()
        {
            List<CategoryData> listData = new List<CategoryData>();

            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectData = "SELECT * FROM categories";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        CategoryData categoryData = new CategoryData();

                        categoryData.ID = (int)reader["id"];
                        categoryData.Category = reader["category"].ToString();
                        categoryData.Type = reader["type"].ToString();
                        categoryData.Status = reader["status"].ToString();
                        categoryData.date_inserted = reader["date_inserted"].ToString();

                        listData.Add(categoryData);
                    }

                }
            }

            return listData;
        }
    }
}
