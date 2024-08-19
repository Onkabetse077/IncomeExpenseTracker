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
        }
        private void btnAdd_Category_Click(object sender, EventArgs e)
        {
            if (tbCategory_Category.Text == "" || cbStatus_Category.SelectedIndex == -1 ||
                cbType_Category.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all balnk fields", "Error Message!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();

                    string insertData = "INSERT INTO categories (category,type,status,date_inserted)" +
                                        " VALUES(@category,@type,@status,@date_inserted)";

                    using (SqlCommand cmd = new SqlCommand(insertData,connect))
                    {
                        cmd.Parameters.AddWithValue("@category", tbCategory_Category.Text.Trim());
                        cmd.Parameters.AddWithValue("@type", cbType_Category.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", cbStatus_Category.Text.Trim());
                        cmd.Parameters.AddWithValue("@date_inserted", DateTime.Today);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Information has been succesfully inserted", "Confrimation Message!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    connect.Close();
                }
            }
        }
    }
}
