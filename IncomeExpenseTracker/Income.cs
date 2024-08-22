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
            displayIncomeList();
        }

        public void displayIncomeList()
        {
            IncomeData incomeData = new IncomeData();

            List<IncomeData> listData = incomeData.incomeListData();

            dgvIncome_Income.DataSource = listData;

            //dgvCategoriesList_Category.Columns["Date"].DefaultCellStyle.Format = "dd/MMM/yyyy";
        }

        private int getID = 0;
        public void displayCategoryList()
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectData = "SELECT category FROM categories WHERE type = @type AND status = @status";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
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
                        cmd.Parameters.AddWithValue("@item", tbItem_Income.Text.Trim());
                        cmd.Parameters.AddWithValue("@income", tbIncome_Income.Text);
                        cmd.Parameters.AddWithValue("@description", tbDescription_Income.Text);
                        cmd.Parameters.AddWithValue("@date_income", dtpIncome_Income.Value);
                        cmd.Parameters.AddWithValue("@date_inserted", DateTime.Today);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Information has been succesfully Added ", "Confirmation Message!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        clearFields();
                    }

                    connect.Close();
                }
            }
        }

        private void btnUpdate_Income_Click(object sender, EventArgs e)
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
                        "UPDATE income SET category = @category,item = @item,income = @income,description = @description,date_income = @date_income)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@category", cbCategory_Income.SelectedItem);
                        cmd.Parameters.AddWithValue("@item", tbItem_Income.Text.Trim());
                        cmd.Parameters.AddWithValue("@income", tbIncome_Income.Text);
                        cmd.Parameters.AddWithValue("@description", tbDescription_Income.Text);
                        cmd.Parameters.AddWithValue("@date_income", dtpIncome_Income.Value);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Information has been succesfully Updated ", "Confirmation Message!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        clearFields();
                    }

                    connect.Close();
                }
            }
        }

        public void clearFields()
        {
            cbCategory_Income.SelectedIndex = -1;
            tbItem_Income.Text = "";
            tbIncome_Income.Text = "";
            tbDescription_Income.Text = "";
            displayIncomeList();
            displayCategoryList();
        }
        private void btnClear_Income_Click(object sender, EventArgs e)
        {
            clearFields();
            
        }

        private void btnDelete_Income_Click(object sender, EventArgs e)
        {


            if (cbCategory_Income.SelectedIndex == -1 || tbItem_Income.Text == "" || tbIncome_Income.Text == "" ||
                tbDescription_Income.Text == "" )
            {
                MessageBox.Show("Please select an item first!", "Error Message!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Delete ID: " + getID + "?", "Confirmation Message",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(connection))
                    {
                        connect.Open();

                        string updateData =
                            "DELETE FROM income WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Information has been succesfully Deleted", "Confirmation Message!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            clearFields();
                        }

                        connect.Close();
                    }
                }
            }
        }
    

    
        private void dgvIncome_Income_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvIncome_Income.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells[0].Value);
                cbCategory_Income.Text = row.Cells[1].Value.ToString();
                tbItem_Income.Text = row.Cells[2].Value.ToString();
                tbIncome_Income.Text = row.Cells[3].Value.ToString();
                tbDescription_Income.Text = row.Cells[4].Value.ToString();
                dtpIncome_Income.Text = row.Cells[5].Value.ToString();

            }
        }
    }
}
