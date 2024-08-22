using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeExpenseTracker
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void signupPageExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are sure you want to Exit?", "Confirmation Message", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SigninPage signinPage = new SigninPage();
                signinPage.Show();
                this.Close();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {


        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            category_Main.Visible = true;
            income_Main.Visible = false;
            expenses_Main.Visible = false;
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            category_Main.Visible = false;
            income_Main.Visible = true;
            expenses_Main.Visible = false;
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            category_Main.Visible = false;
            income_Main.Visible = false;
            expenses_Main.Visible = true;
        }
    }
}
