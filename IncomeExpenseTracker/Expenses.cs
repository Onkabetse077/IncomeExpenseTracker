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
    public partial class Expenses : UserControl
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\gosia\Documents\Projects\Visual Studio\C#\IncomeExpenseTracker\tools\Databases\expense.mdf"";Integrated Security=True;Connect Timeout=30";
        public Expenses()
        {
            InitializeComponent();
            DisplayCategoryList();
            DisplayExpenseList();
        }
        public void DisplayExpenseList()
        {
            ExpenseData expenseData = new ExpenseData();

            List<ExpenseData> listData = expenseData.expenseListData();

            dgvExpense_Expense.DataSource = listData;

            //dgvCategoriesList_Category.Columns["Date"].DefaultCellStyle.Format = "dd/MMM/yyyy";
        }

        private int getID = 0;
        public void DisplayCategoryList()
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectData = "SELECT category FROM categories WHERE type = @type AND status = @status";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@type", "Expenses");
                    cmd.Parameters.AddWithValue("@status", "Active");

                    cbCategory_Expense.Items.Clear();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cbCategory_Expense.Items.Add(reader["category"].ToString());
                    }
                }
            }
        }

        public void ClearFields()
        {
            cbCategory_Expense.SelectedIndex = -1;
            tbItem_Expense.Text = "";
            tbExpense_Expense.Text = "";
            tbDescription_Expense.Text = "";
            DisplayExpenseList();
            DisplayCategoryList();
        }
        private void btnAdd_Expense_Click(object sender, EventArgs e)
        {
            if (cbCategory_Expense.SelectedIndex == -1 || tbItem_Expense.Text == ""
                                                      || tbExpense_Expense.Text == "" || tbDescription_Expense.Text == "")
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
                        "INSERT INTO expense (category,item,expense,description,date_expense,date_inserted) " +
                        "VALUES (@category,@item,@expense,@description,@date_expense,@date_inserted)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@category", cbCategory_Expense.SelectedItem);
                        cmd.Parameters.AddWithValue("@item", tbItem_Expense.Text.Trim());
                        cmd.Parameters.AddWithValue("@expense", tbExpense_Expense.Text);
                        cmd.Parameters.AddWithValue("@description", tbDescription_Expense.Text);
                        cmd.Parameters.AddWithValue("@date_expense", dtpExpense_Expense.Value);
                        cmd.Parameters.AddWithValue("@date_inserted", DateTime.Today);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Information has been succesfully Added ", "Confirmation Message!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ClearFields();
                    }

                    connect.Close();
                }
            }
        }

        private void btnUpdate_Expense_Click(object sender, EventArgs e)
        {
            if (cbCategory_Expense.SelectedIndex == -1 || tbItem_Expense.Text == ""
                                                      || tbExpense_Expense.Text == "" || tbDescription_Expense.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();
                    string updateData =
                        "UPDATE expense SET category = @category,item = @item,expense = @expense,description = @description,date_expense = @date_expense WHERE id =@id)";

                    using (SqlCommand cmd = new SqlCommand(updateData, connect))
                    {
                        cmd.Parameters.AddWithValue("@id", getID);
                        cmd.Parameters.AddWithValue("@category", cbCategory_Expense.SelectedItem);
                        cmd.Parameters.AddWithValue("@item", tbItem_Expense.Text.Trim());
                        cmd.Parameters.AddWithValue("@expense", tbExpense_Expense.Text);
                        cmd.Parameters.AddWithValue("@description", tbDescription_Expense.Text);
                        cmd.Parameters.AddWithValue("@date_expense", dtpExpense_Expense.Value);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Information has been succesfully Updated ", "Confirmation Message!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ClearFields();
                    }

                    connect.Close();
                }
            }
        }

        private void btnClear_Expense_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnDelete_Expense_Click(object sender, EventArgs e)
        {
            if (cbCategory_Expense.SelectedIndex == -1 || tbItem_Expense.Text == "" || tbExpense_Expense.Text == "" ||
                tbDescription_Expense.Text == "")
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
                            "DELETE FROM expense WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Information has been succesfully Deleted", "Confirmation Message!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ClearFields();
                        }

                        connect.Close();
                    }
                }
            }
        }

        private void dgvExpense_Expense_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvExpense_Expense.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells[0].Value);
                cbCategory_Expense.Text = row.Cells[1].Value.ToString();
                tbItem_Expense.Text = row.Cells[2].Value.ToString();
                tbExpense_Expense.Text = row.Cells[3].Value.ToString();
                tbDescription_Expense.Text = row.Cells[4].Value.ToString();
                dtpExpense_Expense.Text = row.Cells[5].Value.ToString();

            }
        }
    }
}
