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
    public partial class Income : UserControl
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\gosia\Documents\Projects\Visual Studio\C#\IncomeExpenseTracker\tools\Databases\expense.mdf"";Integrated Security=True;Connect Timeout=30";
        public Income()
        {
            InitializeComponent();
            displayCategoryList();
        }

        public void displayCategoryList()
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectData = "SELECT category FROM categories WHERE type = @type AND status = @status";

                using (SqlCommand cmd = new SqlCommand(selectData,connect))
                {
                    cmd.Parameters.AddWithValue("@type", "Income");
                    cmd.Parameters.AddWithValue("@status", "Active");

                    cbCategory_Income.Items.Clear();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cbCategory_Income.Items.Add(reader["category"].ToString());
                    }
                }
            }
        }
        private void btnAdd_Income_Click(object sender, EventArgs e)
        {
            if (cbCategory_Income.SelectedIndex == -1 || tbItem_Income.Text == "" 
                                                      || tbIncome_Income.Text == "" || tbDescription_Income.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();
                    string insertData =
                        "INSERT INTO income (category,item,income,description,date_income,date_inserted) " +
                        "VALUES (@category,@item,@income,@description,@date_income,@date_inserted)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@category", cbCategory_Income.SelectedItem);
                        cmd.Parameters.AddWithValue("@item", tbItem_Income.Text);
                        cmd.Parameters.AddWithValue("@income", tbIncome_Income.Text);
                        cmd.Parameters.AddWithValue("@description", tbDescription_Income.Text);
                        cmd.Parameters.AddWithValue("@date_income", dtpIncome_Income.Value);
                        cmd.Parameters.AddWithValue("@date_inserted",DateTime.Today);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Information has been succesfully Added ", "Confirmation Message!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                        connect.Close();
                }
            }
        }
    }
}
