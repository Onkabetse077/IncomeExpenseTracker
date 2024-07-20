namespace IncomeExpenseTracker
{
    public partial class SigninPage : Form
    {
        public SigninPage()
        {
            InitializeComponent();
        }

        private void signinPageExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
