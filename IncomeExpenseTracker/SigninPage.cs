using System.Data.SqlClient;
using System.Data;

namespace IncomeExpenseTracker
{
    public partial class SigninPage : Form
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\gosia\Documents\Projects\Visual Studio\C#\IncomeExpenseTracker\tools\Databases\expense.mdf"";Integrated Security=True;Connect Timeout=30";
        public SigninPage()
        {
            InitializeComponent();
        }

        private void signinPageExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are sure you want to Exit?", "Confirmation Message", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSignupSignin_Click(object sender, EventArgs e)
        {
            SignupPage signupPage = new SignupPage();
            signupPage.Show();
            this.Hide();
        }

        private void cbShowpasswordSignin_CheckedChanged(object sender, EventArgs e)
        {
            tbPasswordSignin.PasswordChar = (cbShowpasswordSignin.Checked) ? '\0' : '#';
        }

        private void btnLoginSignin_Click(object sender, EventArgs e)
        {

            using(SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectData = "SELECT * FROM users WHERE username = @username AND password = @password";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@username",tbUsernameSignin.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", tbPasswordSignin.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    if(table.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successfully","Information Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MainPage mainPage = new MainPage();
                        mainPage.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if(tbUsernameSignin.Text ==""|| tbPasswordSignin.Text == "")
            {
                MessageBox.Show("Please fill in all the details!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
