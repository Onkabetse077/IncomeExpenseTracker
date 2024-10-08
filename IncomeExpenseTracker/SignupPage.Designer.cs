﻿namespace IncomeExpenseTracker
{
    partial class SignupPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSigninSignup = new Button();
            pnlSigninLeft = new Panel();
            lblSigninSignup = new Label();
            lblIETSignup = new Label();
            pbSignupPage = new PictureBox();
            cbShowpasswordSignup = new CheckBox();
            btnSignup = new Button();
            tbPasswordSignup = new TextBox();
            lblPasswordSignup = new Label();
            tbUsernameSignup = new TextBox();
            lblUsernameSignup = new Label();
            lblSignup = new Label();
            signupPageExit = new Label();
            tbConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            pnlSigninLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSignupPage).BeginInit();
            SuspendLayout();
            // 
            // btnSigninSignup
            // 
            btnSigninSignup.BackColor = Color.FromArgb(16, 97, 40);
            btnSigninSignup.Cursor = Cursors.Hand;
            btnSigninSignup.FlatAppearance.BorderSize = 0;
            btnSigninSignup.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 97, 16);
            btnSigninSignup.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 97, 16);
            btnSigninSignup.FlatStyle = FlatStyle.Flat;
            btnSigninSignup.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSigninSignup.ForeColor = SystemColors.ButtonHighlight;
            btnSigninSignup.Location = new Point(-3, 502);
            btnSigninSignup.Name = "btnSigninSignup";
            btnSigninSignup.Size = new Size(380, 44);
            btnSigninSignup.TabIndex = 9;
            btnSigninSignup.Text = "Signin";
            btnSigninSignup.UseVisualStyleBackColor = false;
            btnSigninSignup.Click += btnSigninSignup_Click;
            // 
            // pnlSigninLeft
            // 
            pnlSigninLeft.BackColor = Color.FromArgb(16, 97, 40);
            pnlSigninLeft.Controls.Add(btnSigninSignup);
            pnlSigninLeft.Controls.Add(lblSigninSignup);
            pnlSigninLeft.Controls.Add(lblIETSignup);
            pnlSigninLeft.Controls.Add(pbSignupPage);
            pnlSigninLeft.Dock = DockStyle.Left;
            pnlSigninLeft.Location = new Point(0, 0);
            pnlSigninLeft.Name = "pnlSigninLeft";
            pnlSigninLeft.Size = new Size(380, 600);
            pnlSigninLeft.TabIndex = 9;
            // 
            // lblSigninSignup
            // 
            lblSigninSignup.AutoSize = true;
            lblSigninSignup.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSigninSignup.ForeColor = SystemColors.ButtonHighlight;
            lblSigninSignup.Location = new Point(83, 478);
            lblSigninSignup.Name = "lblSigninSignup";
            lblSigninSignup.Size = new Size(230, 21);
            lblSigninSignup.TabIndex = 2;
            lblSigninSignup.Text = "Have An Account ? Signin";
            // 
            // lblIETSignup
            // 
            lblIETSignup.AutoSize = true;
            lblIETSignup.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIETSignup.ForeColor = SystemColors.ButtonHighlight;
            lblIETSignup.Location = new Point(12, 230);
            lblIETSignup.Name = "lblIETSignup";
            lblIETSignup.Size = new Size(349, 28);
            lblIETSignup.TabIndex = 1;
            lblIETSignup.Text = "Income and Expense Tracker";
            // 
            // pbSignupPage
            // 
            pbSignupPage.Image = Properties.Resources.ProfilePicture;
            pbSignupPage.Location = new Point(136, 102);
            pbSignupPage.Name = "pbSignupPage";
            pbSignupPage.Size = new Size(100, 100);
            pbSignupPage.TabIndex = 0;
            pbSignupPage.TabStop = false;
            // 
            // cbShowpasswordSignup
            // 
            cbShowpasswordSignup.AutoSize = true;
            cbShowpasswordSignup.Location = new Point(662, 424);
            cbShowpasswordSignup.Name = "cbShowpasswordSignup";
            cbShowpasswordSignup.Size = new Size(132, 24);
            cbShowpasswordSignup.TabIndex = 17;
            cbShowpasswordSignup.Text = "Show Password";
            cbShowpasswordSignup.UseVisualStyleBackColor = true;
            cbShowpasswordSignup.CheckedChanged += cbShowpasswordSignup_CheckedChanged;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.FromArgb(16, 97, 40);
            btnSignup.Cursor = Cursors.Hand;
            btnSignup.FlatAppearance.BorderSize = 0;
            btnSignup.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 97, 16);
            btnSignup.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 97, 16);
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignup.ForeColor = SystemColors.ButtonHighlight;
            btnSignup.Location = new Point(407, 478);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(132, 44);
            btnSignup.TabIndex = 16;
            btnSignup.Text = "Signup";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // tbPasswordSignup
            // 
            tbPasswordSignup.BorderStyle = BorderStyle.FixedSingle;
            tbPasswordSignup.Location = new Point(407, 306);
            tbPasswordSignup.Name = "tbPasswordSignup";
            tbPasswordSignup.PasswordChar = '#';
            tbPasswordSignup.Size = new Size(387, 27);
            tbPasswordSignup.TabIndex = 15;
            // 
            // lblPasswordSignup
            // 
            lblPasswordSignup.AutoSize = true;
            lblPasswordSignup.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPasswordSignup.Location = new Point(407, 268);
            lblPasswordSignup.Name = "lblPasswordSignup";
            lblPasswordSignup.Size = new Size(94, 24);
            lblPasswordSignup.TabIndex = 14;
            lblPasswordSignup.Text = "Password";
            // 
            // tbUsernameSignup
            // 
            tbUsernameSignup.BorderStyle = BorderStyle.FixedSingle;
            tbUsernameSignup.Location = new Point(407, 216);
            tbUsernameSignup.Name = "tbUsernameSignup";
            tbUsernameSignup.Size = new Size(387, 27);
            tbUsernameSignup.TabIndex = 13;
            // 
            // lblUsernameSignup
            // 
            lblUsernameSignup.AutoSize = true;
            lblUsernameSignup.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsernameSignup.Location = new Point(407, 178);
            lblUsernameSignup.Name = "lblUsernameSignup";
            lblUsernameSignup.Size = new Size(100, 24);
            lblUsernameSignup.TabIndex = 12;
            lblUsernameSignup.Text = "Username";
            // 
            // lblSignup
            // 
            lblSignup.AutoSize = true;
            lblSignup.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignup.Location = new Point(407, 102);
            lblSignup.Name = "lblSignup";
            lblSignup.Size = new Size(124, 34);
            lblSignup.TabIndex = 11;
            lblSignup.Text = "Sign Up";
            // 
            // signupPageExit
            // 
            signupPageExit.AutoSize = true;
            signupPageExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupPageExit.Location = new Point(770, 9);
            signupPageExit.Name = "signupPageExit";
            signupPageExit.Size = new Size(24, 24);
            signupPageExit.TabIndex = 10;
            signupPageExit.Text = "X";
            signupPageExit.Click += signupPageExit_Click;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            tbConfirmPassword.Location = new Point(407, 391);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.PasswordChar = '#';
            tbConfirmPassword.Size = new Size(387, 27);
            tbConfirmPassword.TabIndex = 19;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.Location = new Point(407, 354);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(169, 24);
            lblConfirmPassword.TabIndex = 18;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // SignupPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(tbConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(pnlSigninLeft);
            Controls.Add(cbShowpasswordSignup);
            Controls.Add(btnSignup);
            Controls.Add(tbPasswordSignup);
            Controls.Add(lblPasswordSignup);
            Controls.Add(tbUsernameSignup);
            Controls.Add(lblUsernameSignup);
            Controls.Add(lblSignup);
            Controls.Add(signupPageExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignupPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignupPage";
            pnlSigninLeft.ResumeLayout(false);
            pnlSigninLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSignupPage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSigninSignup;
        private Panel pnlSigninLeft;
        private Label lblSigninSignup;
        private Label lblIETSignup;
        private PictureBox pbSignupPage;
        private CheckBox cbShowpasswordSignup;
        private Button btnSignup;
        private TextBox tbPasswordSignup;
        private Label lblPasswordSignup;
        private TextBox tbUsernameSignup;
        private Label lblUsernameSignup;
        private Label lblSignup;
        private Label signupPageExit;
        private TextBox tbConfirmPassword;
        private Label lblConfirmPassword;
    }
}