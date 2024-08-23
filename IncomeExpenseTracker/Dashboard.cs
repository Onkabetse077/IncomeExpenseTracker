using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace IncomeExpenseTracker
{
    public partial class Dashboard : UserControl
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\gosia\Documents\Projects\Visual Studio\C#\IncomeExpenseTracker\tools\Databases\expense.mdf"";Integrated Security=True;Connect Timeout=30";
        public Dashboard()
        {
            InitializeComponent();
            IncomeTodayIncome();
        }


        public void IncomeTodayIncome()
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string query =
                    "SELECT SUM(income) FROM income WHERE date_income = @date_income";

                using (SqlCommand cmd = new SqlCommand(query,connect))
                {
                    cmd.Parameters.AddWithValue("@date_income", DateTime.Today);

                    object results = cmd.ExecuteScalar();

                    if (results != DBNull.Value)
                    {
                        decimal todayIncome = Convert.ToDecimal(results);

                        lblIncomeDataTodayIncome.Text = "R" + todayIncome.ToString("0,00");
                    }
                    else
                    {
                        lblIncomeDataTodayIncome.Text = "R 0,00";
                    }
                }
            }
        }
        public void IncomeYesterdayIncome()
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string query =
                    "SELECT SUM(income) FROM income WHERE CONVERT(DATE,TIMESTAMPS) = DATEADD(day,DATEDIFF(day,0,GETDATE()),-1)";

                using (SqlCommand cmd =new SqlCommand(query,connect) )
                {
                    object results = cmd.ExecuteScalar();

                    if (results == DBNull.Value)
                    {
                        
                    }
                }
            }
        }

    }
}
