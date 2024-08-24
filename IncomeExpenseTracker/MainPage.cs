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
            DisplayUsername();
        }

        public void DisplayUsername()
        {
            string getUsername = SigninPage.username;
            lblUsername_Main.Text = getUsername;
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
            dashboard_Main.Visible = true;
            category_Main.Visible = false;
            income_Main.Visible = false;
            expenses_Main.Visible = false;

            Dashboard dashboard = dashboard_Main as Dashboard;

            if (dashboard != null)
            {
                dashboard.RefreshData();
            }

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            dashboard_Main.Visible = false;
            category_Main.Visible = true;
            income_Main.Visible = false;
            expenses_Main.Visible = false;

            Category category = category_Main as Category;

            if (category != null)
            {
                category.RefreshData();
            }
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            dashboard_Main.Visible = false;
            category_Main.Visible = false;
            income_Main.Visible = true;
            expenses_Main.Visible = false;

            Income income = income_Main as Income;

            if (income != null)
            {
                income.RefreshData();
            }
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            dashboard_Main.Visible = false;
            category_Main.Visible = false;
            income_Main.Visible = false;
            expenses_Main.Visible = true;

            Expenses expense = expenses_Main as Expenses;

            if (expense != null)
            {
                expense.RefreshData();
            }
        }
    }
}
