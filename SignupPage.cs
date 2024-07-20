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
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Onkabetse\Documents\Projects\Visual Studio\C#\IncomeExpenseTracker\IncomeExpenseTracker\tools\Databases\expenses.mdf"";Integrated Security=True;Connect Timeout=30");
        public SignupPage()
        {
            InitializeComponent();
        }

        public bool checkConnectonStatus()
        {
            try
            {
                connection.Open();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
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

        }
    }
}
