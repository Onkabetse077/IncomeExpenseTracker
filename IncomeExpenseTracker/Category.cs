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
    public partial class Category : UserControl
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\gosia\Documents\Projects\Visual Studio\C#\IncomeExpenseTracker\tools\Databases\expense.mdf"";Integrated Security=True;Connect Timeout=30";
        public Category()
        {
            InitializeComponent();
            displayCategoryList();
        }

        public void displayCategoryList()
        {
            CategoryData categoryData = new CategoryData();

            List<CategoryData> listData = categoryData.categoryListData();

            dgvCategoriesList_Category.DataSource = listData;

            //dgvCategoriesList_Category.Columns["Date"].DefaultCellStyle.Format = "dd/MMM/yyyy";
        }
        private void btnAdd_Category_Click(object sender, EventArgs e)
        {
            if (tbCategory_Category.Text == "" || cbStatus_Category.SelectedIndex == -1 ||
                cbType_Category.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all blank fields!", "Error Message!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();

                    string insertData = "INSERT INTO categories (category,type,status,date_inserted)" +
                                        " VALUES(@category,@type,@status,@date_inserted)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@category", tbCategory_Category.Text.Trim());
                        cmd.Parameters.AddWithValue("@type", cbType_Category.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", cbStatus_Category.Text.Trim());
                        cmd.Parameters.AddWithValue("@date_inserted", DateTime.Today.Date);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Information has been succesfully Added ", "Confirmation Message!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        clearFields();
                    }

                    connect.Close();
                }
            }
            displayCategoryList();

        }

        private int getID = 0;
        private void dgvCategoriesList_Category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvCategoriesList_Category.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells[0].Value);
                tbCategory_Category.Text = row.Cells[1].Value.ToString();
                cbType_Category.SelectedItem = row.Cells[2].Value.ToString();
                cbStatus_Category.SelectedItem = row.Cells[3].Value.ToString();
            }
        }

        private void btnUpdate_Category_Click(object sender, EventArgs e)
        {
            if (tbCategory_Category.Text == "" || cbStatus_Category.SelectedIndex == -1 ||
                cbType_Category.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item first!", "Error Message!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Update ID: " + getID + "?", "Confirmation Message",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(connection))
                    {
                        connect.Open();

                        string updateData =
                            "UPDATE categories SET category = @category,type = @type,status = @status WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);
                            cmd.Parameters.AddWithValue("@category", tbCategory_Category.Text.Trim());
                            cmd.Parameters.AddWithValue("@type", cbType_Category.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", cbStatus_Category.Text.Trim());
                            cmd.Parameters.AddWithValue("@date_inserted", DateTime.Today.Date);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Information has been succesfully Updated", "Confrimation Message!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            clearFields();
                        }

                        connect.Close();
                    }
                }
            }
            displayCategoryList();
        }

        public void clearFields()
        {
            tbCategory_Category.Text = "";
            cbType_Category.SelectedIndex = -1;
            cbStatus_Category.SelectedIndex = -1;
        }
        private void btnClear_Category_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnDelete_Category_Click(object sender, EventArgs e)
        {
            if (tbCategory_Category.Text == "" || cbStatus_Category.SelectedIndex == -1 ||
                cbType_Category.SelectedIndex == -1)
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
                            "DELETE FROM categories WHERE id = @id";

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
            displayCategoryList();
        }
    }
}
