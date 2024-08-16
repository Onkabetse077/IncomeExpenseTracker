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
    public partial class SignupPage : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\gosia\Documents\Projects\Visual Studio\C#\IncomeExpenseTracker\tools\Databases\expense.mdf"";Integrated Security=True;Connect Timeout=30");
        public SignupPage()
        {
            InitializeComponent();
        }

        public bool checkConnectonStatus()
        {
            return (connection.State == ConnectionState.Closed) ? true : false;
        }

        private void signupPageExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSigninSignup_Click(object sender, EventArgs e)
        {
            SigninPage signinPage = new SigninPage();
            signinPage.Show();
            this.Hide();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if(tbUsernameSignup.Text ==""||tbPasswordSignup.Text == ""||tbConfirmPassword.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(tbPasswordSignup.Text != tbConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnectonStatus())
                {
                    try
                    {
                        connection.Open();

                        string query = "SELECT * FROM users WHERE username = @username";

                        using (SqlCommand checkUser = new SqlCommand(query, connection))
                        {
                            checkUser.Parameters.AddWithValue("@username",tbUsernameSignup.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();

                           adapter.Fill(table);

                            if(table.Rows.Count !=0)
                            {
                                string tempUsername = tbUsernameSignup.Text.Substring(0,1).ToUpper() + tbUsernameSignup.Text.Substring(1);
                                MessageBox.Show(tempUsername + " is existing already","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }else if(tbPasswordSignup.Text.Length < 8){
                                MessageBox.Show("password is too short","Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users(username ,password,date_created) VALUES (@username,@password,@date)";

                                using (SqlCommand insertUser = new SqlCommand(insertData, connection)) 
                                {
                                    insertUser.Parameters.AddWithValue("@username",tbUsernameSignup.Text.Trim());
                                    insertUser.Parameters.AddWithValue("@password", tbPasswordSignup.Text.Trim());
                                    insertUser.Parameters.AddWithValue("@date",DateTime.Today);

                                    insertUser.ExecuteNonQuery();

                                    MessageBox.Show("User Registered Successfully","Informaton Message",MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    SigninPage loginform = new SigninPage();

                                    loginform.Show();
                                    this.Hide();

                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed Connection" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                
            }
        }

        private void cbShowpasswordSignup_CheckedChanged(object sender, EventArgs e)
        {
            tbPasswordSignup.PasswordChar = (cbShowpasswordSignup.Checked) ? '\0' : '#';
            tbConfirmPassword.PasswordChar = (cbShowpasswordSignup.Checked) ? '\0' : '#';
        }
    }
}
