﻿using System;
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
            IncomeYesterdayIncome();
            IncomeThisMonth();
            IncomeThisYear();

            ExpenseTodayExpense();
            ExpenseYesterdayExpense();
            ExpenseThisMonth();
            ExpenseThisYear();

            TotalIncome();
            TotalExpense();
            
            RefreshData();
        }


        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
            }
            IncomeTodayIncome();
            IncomeYesterdayIncome();
            IncomeThisMonth();
            IncomeThisYear();

            ExpenseTodayExpense();
            ExpenseYesterdayExpense();
            ExpenseThisMonth();
            ExpenseThisYear();

            TotalIncome();
            TotalExpense();
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

                        lblIncomeDataTodayIncome.Text = todayIncome.ToString("C");
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
                    "SELECT SUM(income) FROM income WHERE CONVERT(DATE,date_income) = DATEADD(day,DATEDIFF(day,0,GETDATE()),-1)";

                using (SqlCommand cmd =new SqlCommand(query,connect) )
                {
                    object results = cmd.ExecuteScalar();

                    if (results != DBNull.Value)
                    {
                        decimal yesterdayIncome  = Convert.ToDecimal(results);

                        lblIncomeDataYesterdayIncome.Text = yesterdayIncome.ToString("C");
                    }
                    else
                    {
                        lblIncomeDataYesterdayIncome.Text = "R 0,00";
                    }
                }
            }
        }

        public void IncomeThisMonth()
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                DateTime today = DateTime.Now.Date;
                DateTime startMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);


                string query =
                    "SELECT SUM(income) FROM income WHERE date_income >= @startMonth AND date_income <= @endMonth";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {

                    cmd.Parameters.AddWithValue("@startMonth", startMonth);
                    cmd.Parameters.AddWithValue("@endMonth", endMonth);

                    object results = cmd.ExecuteScalar();

                    if (results != DBNull.Value)
                    {
                        decimal MonthIncome = Convert.ToDecimal(results);

                        lblIncomeDataMonthIncome.Text = MonthIncome.ToString("C");
                    }
                    else
                    {
                        lblIncomeDataMonthIncome.Text = "R 0,00";
                    }
                }
            }

        }

        public void IncomeThisYear()
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                DateTime today = DateTime.Now.Date;
                DateTime startYear = new DateTime(today.Year, 1, 1);
                DateTime endYear = startYear.AddYears(1).AddDays(-1);


                string query =
                    "SELECT SUM(income) FROM income WHERE date_income >= @startYear AND date_income <= @endYear";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {

                    cmd.Parameters.AddWithValue("@startYear", startYear);
                    cmd.Parameters.AddWithValue("@endYear", endYear);
                    object results = cmd.ExecuteScalar();

                    if (results != DBNull.Value)
                    {
                        decimal yearIncome = Convert.ToDecimal(results);

                        lblIncomeDataYearIncome.Text = yearIncome.ToString("C");
                    }
                    else
                    {
                        lblIncomeDataYearIncome.Text = "R 0,00";
                    }
                }
            }
            
        }



        public void ExpenseTodayExpense()
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string query =
                    "SELECT SUM(expense) FROM expense WHERE date_expense = @date_expense";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@date_expense", DateTime.Today);

                    object results = cmd.ExecuteScalar();

                    if (results != DBNull.Value)
                    {
                        decimal todayExpense = Convert.ToDecimal(results);

                        lblExpenseDataTodayExpense.Text = todayExpense.ToString("C");
                    }
                    else
                    {
                        lblIncomeDataTodayIncome.Text = "R 0,00";
                    }
                }
            }
        }
        public void ExpenseYesterdayExpense()
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string query =
                    "SELECT SUM(expense) FROM expense WHERE CONVERT(DATE,date_expense) = DATEADD(day,DATEDIFF(day,0,GETDATE()),-1)";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    object results = cmd.ExecuteScalar();

                    if (results != DBNull.Value)
                    {
                        decimal yesterdayExpense = Convert.ToDecimal(results);

                        lblExpenseDataYesterdayExpense.Text = yesterdayExpense.ToString("C");
                    }
                    else
                    {
                        lblExpenseDataYesterdayExpense.Text = "R 0,00";
                    }
                }
            }
        }

        public void ExpenseThisMonth()
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                DateTime today = DateTime.Now.Date;
                DateTime startMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);


                string query =
                    "SELECT SUM(expense) FROM expense WHERE date_expense >= @startMonth AND date_expense <= @endMonth";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {

                    cmd.Parameters.AddWithValue("@startMonth", startMonth);
                    cmd.Parameters.AddWithValue("@endMonth", endMonth);

                    object results = cmd.ExecuteScalar();

                    if (results != DBNull.Value)
                    {
                        decimal MonthExpense = Convert.ToDecimal(results);

                        lblExpenseDataMonthExpense.Text = MonthExpense.ToString("C");
                    }
                    else
                    {
                        lblExpenseDataMonthExpense.Text = "R 0,00";
                    }
                }
            }

        }

        public void ExpenseThisYear()
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                DateTime today = DateTime.Now.Date;
                DateTime startYear = new DateTime(today.Year, 1, 1);
                DateTime endYear = startYear.AddYears(1).AddDays(-1);


                string query =
                    "SELECT SUM(expense) FROM expense WHERE date_expense >= @startYear AND date_expense <= @endYear";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {

                    cmd.Parameters.AddWithValue("@startYear", startYear);
                    cmd.Parameters.AddWithValue("@endYear", endYear);
                    object results = cmd.ExecuteScalar();

                    if (results != DBNull.Value)
                    {
                        decimal yearExpense = Convert.ToDecimal(results);

                        lblExpenseDataYearExpense.Text = yearExpense.ToString("C");
                    }
                    else
                    {
                        lblExpenseDataYearExpense.Text = "R 0,00";
                    }
                }
            }

        }

        public void TotalIncome()
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string query =
                    "SELECT SUM(income) FROM income";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    object results = cmd.ExecuteScalar();

                    if (results != DBNull.Value)
                    {
                        decimal todayIncome = Convert.ToDecimal(results);

                        lblIncomeTotal.Text = todayIncome.ToString("C");
                    }
                    else
                    {
                        lblIncomeTotal.Text = "R 0,00";
                    }
                }
            }
        }

        public void TotalExpense()
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string query =
                    "SELECT SUM(expense) FROM expense";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    object results = cmd.ExecuteScalar();

                    if (results != DBNull.Value)
                    {
                        decimal totalIncome = Convert.ToDecimal(results);

                        lblExpenseTotal.Text = totalIncome.ToString("C");
                    }
                    else
                    {
                        lblExpenseTotal.Text = "R 0,00";
                    }
                }
            }
        }
    }
}
