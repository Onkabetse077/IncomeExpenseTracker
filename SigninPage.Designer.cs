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
            lblIETSignin = new Label();
            pbSigninPage = new PictureBox();
            signinPageExit = new Label();
            lblSignin = new Label();
            lblUsernameSignin = new Label();
            tbUsernameSignin = new TextBox();
            tbPasswordSignin = new TextBox();
            lblPasswordSignin = new Label();
            pnlSigninLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSigninPage).BeginInit();
            SuspendLayout();
            // 
            // pnlSigninLeft
            // 
            pnlSigninLeft.BackColor = Color.FromArgb(84, 116, 70);
            pnlSigninLeft.Controls.Add(lblIETSignin);
            pnlSigninLeft.Controls.Add(pbSigninPage);
            pnlSigninLeft.Dock = DockStyle.Left;
            pnlSigninLeft.Location = new Point(0, 0);
            pnlSigninLeft.Name = "pnlSigninLeft";
            pnlSigninLeft.Size = new Size(380, 600);
            pnlSigninLeft.TabIndex = 0;
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
            tbUsernameSignin.Location = new Point(401, 216);
            tbUsernameSignin.Name = "tbUsernameSignin";
            tbUsernameSignin.Size = new Size(387, 27);
            tbUsernameSignin.TabIndex = 4;
            // 
            // tbPasswordSignin
            // 
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
            // SigninPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 600);
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
    }
}
