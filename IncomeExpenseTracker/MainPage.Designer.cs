namespace IncomeExpenseTracker
{
    partial class MainPage
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
            pnlHeaderMainPage = new Panel();
            pbLogo = new PictureBox();
            lblIncomExpenseTracker = new Label();
            MainPageExit = new Label();
            pnlSideMainPage = new Panel();
            btnLogout = new Button();
            btnExpense = new Button();
            btnIncome = new Button();
            btnCategory = new Button();
            btnDashboard = new Button();
            label1 = new Label();
            lblWelcome = new Label();
            pbMainProfilePic = new PictureBox();
            pnlMain = new Panel();
            category_Main = new Category();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pnlHeaderMainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlSideMainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMainProfilePic).BeginInit();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeaderMainPage
            // 
            pnlHeaderMainPage.BackColor = SystemColors.ButtonHighlight;
            pnlHeaderMainPage.Controls.Add(pbLogo);
            pnlHeaderMainPage.Controls.Add(lblIncomExpenseTracker);
            pnlHeaderMainPage.Controls.Add(MainPageExit);
            pnlHeaderMainPage.Dock = DockStyle.Top;
            pnlHeaderMainPage.Location = new Point(0, 0);
            pnlHeaderMainPage.Name = "pnlHeaderMainPage";
            pnlHeaderMainPage.Size = new Size(1500, 60);
            pnlHeaderMainPage.TabIndex = 0;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.logo;
            pbLogo.Location = new Point(12, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(40, 40);
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            // 
            // lblIncomExpenseTracker
            // 
            lblIncomExpenseTracker.AutoSize = true;
            lblIncomExpenseTracker.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIncomExpenseTracker.Location = new Point(58, 28);
            lblIncomExpenseTracker.Name = "lblIncomExpenseTracker";
            lblIncomExpenseTracker.Size = new Size(304, 24);
            lblIncomExpenseTracker.TabIndex = 12;
            lblIncomExpenseTracker.Text = "Income and Expense Tracker";
            // 
            // MainPageExit
            // 
            MainPageExit.AutoSize = true;
            MainPageExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainPageExit.Location = new Point(1464, 9);
            MainPageExit.Name = "MainPageExit";
            MainPageExit.Size = new Size(24, 24);
            MainPageExit.TabIndex = 11;
            MainPageExit.Text = "X";
            MainPageExit.Click += signupPageExit_Click;
            // 
            // pnlSideMainPage
            // 
            pnlSideMainPage.BackColor = Color.FromArgb(16, 97, 40);
            pnlSideMainPage.Controls.Add(btnLogout);
            pnlSideMainPage.Controls.Add(btnExpense);
            pnlSideMainPage.Controls.Add(btnIncome);
            pnlSideMainPage.Controls.Add(btnCategory);
            pnlSideMainPage.Controls.Add(btnDashboard);
            pnlSideMainPage.Controls.Add(label1);
            pnlSideMainPage.Controls.Add(lblWelcome);
            pnlSideMainPage.Controls.Add(pbMainProfilePic);
            pnlSideMainPage.Dock = DockStyle.Left;
            pnlSideMainPage.Location = new Point(0, 60);
            pnlSideMainPage.Name = "pnlSideMainPage";
            pnlSideMainPage.Size = new Size(265, 740);
            pnlSideMainPage.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 97, 16);
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 97, 16);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Image = Properties.Resources.logout;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(12, 678);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(239, 50);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnExpense
            // 
            btnExpense.FlatAppearance.BorderSize = 0;
            btnExpense.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 97, 16);
            btnExpense.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 97, 16);
            btnExpense.FlatStyle = FlatStyle.Flat;
            btnExpense.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExpense.ForeColor = SystemColors.ButtonHighlight;
            btnExpense.Image = Properties.Resources.expense;
            btnExpense.ImageAlign = ContentAlignment.MiddleLeft;
            btnExpense.Location = new Point(12, 419);
            btnExpense.Name = "btnExpense";
            btnExpense.Size = new Size(239, 50);
            btnExpense.TabIndex = 7;
            btnExpense.Text = "Expense";
            btnExpense.UseVisualStyleBackColor = true;
            // 
            // btnIncome
            // 
            btnIncome.FlatAppearance.BorderSize = 0;
            btnIncome.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 97, 16);
            btnIncome.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 97, 16);
            btnIncome.FlatStyle = FlatStyle.Flat;
            btnIncome.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIncome.ForeColor = SystemColors.ButtonHighlight;
            btnIncome.Image = Properties.Resources.income;
            btnIncome.ImageAlign = ContentAlignment.MiddleLeft;
            btnIncome.Location = new Point(12, 363);
            btnIncome.Name = "btnIncome";
            btnIncome.Size = new Size(239, 50);
            btnIncome.TabIndex = 6;
            btnIncome.Text = "Income";
            btnIncome.UseVisualStyleBackColor = true;
            // 
            // btnCategory
            // 
            btnCategory.FlatAppearance.BorderSize = 0;
            btnCategory.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 97, 16);
            btnCategory.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 97, 16);
            btnCategory.FlatStyle = FlatStyle.Flat;
            btnCategory.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategory.ForeColor = SystemColors.ButtonHighlight;
            btnCategory.Image = Properties.Resources.category;
            btnCategory.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategory.Location = new Point(12, 307);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(239, 50);
            btnCategory.TabIndex = 5;
            btnCategory.Text = "Add Category";
            btnCategory.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 97, 16);
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 97, 16);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = SystemColors.ButtonHighlight;
            btnDashboard.Image = Properties.Resources.dashboard;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(12, 251);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(239, 50);
            btnDashboard.TabIndex = 4;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(111, 194);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 3;
            label1.Text = "Admin";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.ButtonHighlight;
            lblWelcome.Location = new Point(12, 194);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(93, 21);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Welcome,";
            // 
            // pbMainProfilePic
            // 
            pbMainProfilePic.Image = Properties.Resources.ProfilePicture;
            pbMainProfilePic.Location = new Point(83, 60);
            pbMainProfilePic.Name = "pbMainProfilePic";
            pbMainProfilePic.Size = new Size(100, 100);
            pbMainProfilePic.TabIndex = 2;
            pbMainProfilePic.TabStop = false;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(category_Main);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(265, 60);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1235, 740);
            pnlMain.TabIndex = 2;
            // 
            // category_Main
            // 
            category_Main.Dock = DockStyle.Fill;
            category_Main.Location = new Point(0, 0);
            category_Main.Name = "category_Main";
            category_Main.Size = new Size(1235, 740);
            category_Main.TabIndex = 0;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 800);
            Controls.Add(pnlMain);
            Controls.Add(pnlSideMainPage);
            Controls.Add(pnlHeaderMainPage);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainPage";
            pnlHeaderMainPage.ResumeLayout(false);
            pnlHeaderMainPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlSideMainPage.ResumeLayout(false);
            pnlSideMainPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbMainProfilePic).EndInit();
            pnlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeaderMainPage;
        private Label MainPageExit;
        private Label lblIncomExpenseTracker;
        private PictureBox pbLogo;
        private Panel pnlSideMainPage;
        private PictureBox pbMainProfilePic;
        private Label lblWelcome;
        private Label label1;
        private Button btnDashboard;
        private Button btnExpense;
        private Button btnIncome;
        private Button btnCategory;
        private Button btnLogout;
        private Panel pnlMain;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Category category_Main;
    }
}