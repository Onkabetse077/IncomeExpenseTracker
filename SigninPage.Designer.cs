namespace IncomeExpenseTracker
{
    partial class SigninPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlSigninLeft = new Panel();
            btnSignUPSignin = new Button();
            lblSignupSignin = new Label();
            lblIETSignin = new Label();
            pbSigninPage = new PictureBox();
            signinPageExit = new Label();
            lblSignin = new Label();
            lblUsernameSignin = new Label();
            tbUsernameSignin = new TextBox();
            tbPasswordSignin = new TextBox();
            lblPasswordSignin = new Label();
            btnLoginSignin = new Button();
            cbShowpasswordSignin = new CheckBox();
            pnlSigninLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSigninPage).BeginInit();
            SuspendLayout();
            // 
            // pnlSigninLeft
            // 
            pnlSigninLeft.BackColor = Color.FromArgb(16, 97, 40);
            pnlSigninLeft.Controls.Add(btnSignUPSignin);
            pnlSigninLeft.Controls.Add(lblSignupSignin);
            pnlSigninLeft.Controls.Add(lblIETSignin);
            pnlSigninLeft.Controls.Add(pbSigninPage);
            pnlSigninLeft.Dock = DockStyle.Left;
            pnlSigninLeft.Location = new Point(0, 0);
            pnlSigninLeft.Name = "pnlSigninLeft";
            pnlSigninLeft.Size = new Size(380, 600);
            pnlSigninLeft.TabIndex = 0;
            // 
            // btnSignUPSignin
            // 
            btnSignUPSignin.BackColor = Color.FromArgb(16, 97, 40);
            btnSignUPSignin.Cursor = Cursors.Hand;
            btnSignUPSignin.FlatAppearance.BorderSize = 0;
            btnSignUPSignin.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 97, 16);
            btnSignUPSignin.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 97, 16);
            btnSignUPSignin.FlatStyle = FlatStyle.Flat;
            btnSignUPSignin.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUPSignin.ForeColor = SystemColors.ButtonHighlight;
            btnSignUPSignin.Location = new Point(-3, 502);
            btnSignUPSignin.Name = "btnSignUPSignin";
            btnSignUPSignin.Size = new Size(380, 44);
            btnSignUPSignin.TabIndex = 9;
            btnSignUPSignin.Text = "Signup";
            btnSignUPSignin.UseVisualStyleBackColor = false;
            // 
            // lblSignupSignin
            // 
            lblSignupSignin.AutoSize = true;
            lblSignupSignin.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignupSignin.ForeColor = SystemColors.ButtonHighlight;
            lblSignupSignin.Location = new Point(21, 478);
            lblSignupSignin.Name = "lblSignupSignin";
            lblSignupSignin.Size = new Size(344, 21);
            lblSignupSignin.TabIndex = 2;
            lblSignupSignin.Text = "Don't Have An Account ? Register Here";
            // 
            // lblIETSignin
            // 
            lblIETSignin.AutoSize = true;
            lblIETSignin.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIETSignin.ForeColor = SystemColors.ButtonHighlight;
            lblIETSignin.Location = new Point(12, 230);
            lblIETSignin.Name = "lblIETSignin";
            lblIETSignin.Size = new Size(349, 28);
            lblIETSignin.TabIndex = 1;
            lblIETSignin.Text = "Income and Expense Tracker";
            // 
            // pbSigninPage
            // 
            pbSigninPage.Image = Properties.Resources.ProfilePicture;
            pbSigninPage.Location = new Point(136, 102);
            pbSigninPage.Name = "pbSigninPage";
            pbSigninPage.Size = new Size(100, 100);
            pbSigninPage.TabIndex = 0;
            pbSigninPage.TabStop = false;
            // 
            // signinPageExit
            // 
            signinPageExit.AutoSize = true;
            signinPageExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signinPageExit.Location = new Point(764, 9);
            signinPageExit.Name = "signinPageExit";
            signinPageExit.Size = new Size(24, 24);
            signinPageExit.TabIndex = 1;
            signinPageExit.Text = "X";
            signinPageExit.Click += signinPageExit_Click;
            // 
            // lblSignin
            // 
            lblSignin.AutoSize = true;
            lblSignin.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignin.Location = new Point(401, 102);
            lblSignin.Name = "lblSignin";
            lblSignin.Size = new Size(117, 34);
            lblSignin.TabIndex = 2;
            lblSignin.Text = "Sign In";
            // 
            // lblUsernameSignin
            // 
            lblUsernameSignin.AutoSize = true;
            lblUsernameSignin.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsernameSignin.Location = new Point(401, 178);
            lblUsernameSignin.Name = "lblUsernameSignin";
            lblUsernameSignin.Size = new Size(100, 24);
            lblUsernameSignin.TabIndex = 3;
            lblUsernameSignin.Text = "Username";
            // 
            // tbUsernameSignin
            // 
            tbUsernameSignin.BorderStyle = BorderStyle.FixedSingle;
            tbUsernameSignin.Location = new Point(401, 216);
            tbUsernameSignin.Name = "tbUsernameSignin";
            tbUsernameSignin.Size = new Size(387, 27);
            tbUsernameSignin.TabIndex = 4;
            // 
            // tbPasswordSignin
            // 
            tbPasswordSignin.BorderStyle = BorderStyle.FixedSingle;
            tbPasswordSignin.Location = new Point(401, 306);
            tbPasswordSignin.Name = "tbPasswordSignin";
            tbPasswordSignin.Size = new Size(387, 27);
            tbPasswordSignin.TabIndex = 6;
            // 
            // lblPasswordSignin
            // 
            lblPasswordSignin.AutoSize = true;
            lblPasswordSignin.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPasswordSignin.Location = new Point(401, 268);
            lblPasswordSignin.Name = "lblPasswordSignin";
            lblPasswordSignin.Size = new Size(94, 24);
            lblPasswordSignin.TabIndex = 5;
            lblPasswordSignin.Text = "Password";
            // 
            // btnLoginSignin
            // 
            btnLoginSignin.BackColor = Color.FromArgb(16, 97, 40);
            btnLoginSignin.Cursor = Cursors.Hand;
            btnLoginSignin.FlatAppearance.BorderSize = 0;
            btnLoginSignin.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 97, 16);
            btnLoginSignin.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 97, 16);
            btnLoginSignin.FlatStyle = FlatStyle.Flat;
            btnLoginSignin.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginSignin.ForeColor = SystemColors.ButtonHighlight;
            btnLoginSignin.Location = new Point(401, 390);
            btnLoginSignin.Name = "btnLoginSignin";
            btnLoginSignin.Size = new Size(132, 44);
            btnLoginSignin.TabIndex = 7;
            btnLoginSignin.Text = "Login";
            btnLoginSignin.UseVisualStyleBackColor = false;
            // 
            // cbShowpasswordSignin
            // 
            cbShowpasswordSignin.AutoSize = true;
            cbShowpasswordSignin.Location = new Point(656, 352);
            cbShowpasswordSignin.Name = "cbShowpasswordSignin";
            cbShowpasswordSignin.Size = new Size(132, 24);
            cbShowpasswordSignin.TabIndex = 8;
            cbShowpasswordSignin.Text = "Show Password";
            cbShowpasswordSignin.UseVisualStyleBackColor = true;
            // 
            // SigninPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 600);
            Controls.Add(cbShowpasswordSignin);
            Controls.Add(btnLoginSignin);
            Controls.Add(tbPasswordSignin);
            Controls.Add(lblPasswordSignin);
            Controls.Add(tbUsernameSignin);
            Controls.Add(lblUsernameSignin);
            Controls.Add(lblSignin);
            Controls.Add(signinPageExit);
            Controls.Add(pnlSigninLeft);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SigninPage";
            Text = "Sign In";
            pnlSigninLeft.ResumeLayout(false);
            pnlSigninLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSigninPage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSigninLeft;
        private Label signinPageExit;
        private Label lblIETSignin;
        private PictureBox pbSigninPage;
        private Label lblSignin;
        private Label lblUsernameSignin;
        private TextBox tbUsernameSignin;
        private TextBox tbPasswordSignin;
        private Label lblPasswordSignin;
        private Button btnLoginSignin;
        private CheckBox cbShowpasswordSignin;
        private Label lblSignupSignin;
        private Button btnSignUPSignin;
    }
}
