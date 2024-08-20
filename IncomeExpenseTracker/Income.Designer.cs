namespace IncomeExpenseTracker
{
    partial class Income
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlIncomeList_Income = new Panel();
            dataGridView1 = new DataGridView();
            lblIncomeList_Income = new Label();
            pnlCategory_Income = new Panel();
            tbItem_Income = new TextBox();
            lblItem_Income = new Label();
            cbCategory_Income = new ComboBox();
            lblCatogory_Income = new Label();
            tbIncome_Income = new TextBox();
            lblIncome_Income = new Label();
            tbDescription_Income = new TextBox();
            lblDescription_income = new Label();
            lblDate_Income = new Label();
            dtpIncome_Income = new DateTimePicker();
            btnUpdate_Income = new Button();
            btnAdd_Income = new Button();
            btnDelete_Income = new Button();
            btnClear_Income = new Button();
            pnlIncomeList_Income.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlCategory_Income.SuspendLayout();
            SuspendLayout();
            // 
            // pnlIncomeList_Income
            // 
            pnlIncomeList_Income.Controls.Add(dataGridView1);
            pnlIncomeList_Income.Controls.Add(lblIncomeList_Income);
            pnlIncomeList_Income.Location = new Point(18, 30);
            pnlIncomeList_Income.Name = "pnlIncomeList_Income";
            pnlIncomeList_Income.Size = new Size(1201, 375);
            pnlIncomeList_Income.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1154, 306);
            dataGridView1.TabIndex = 1;
            // 
            // lblIncomeList_Income
            // 
            lblIncomeList_Income.AutoSize = true;
            lblIncomeList_Income.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIncomeList_Income.Location = new Point(25, 18);
            lblIncomeList_Income.Name = "lblIncomeList_Income";
            lblIncomeList_Income.Size = new Size(108, 25);
            lblIncomeList_Income.TabIndex = 0;
            lblIncomeList_Income.Text = "Income List";
            // 
            // pnlCategory_Income
            // 
            pnlCategory_Income.Controls.Add(btnDelete_Income);
            pnlCategory_Income.Controls.Add(btnClear_Income);
            pnlCategory_Income.Controls.Add(btnUpdate_Income);
            pnlCategory_Income.Controls.Add(btnAdd_Income);
            pnlCategory_Income.Controls.Add(dtpIncome_Income);
            pnlCategory_Income.Controls.Add(lblDate_Income);
            pnlCategory_Income.Controls.Add(tbDescription_Income);
            pnlCategory_Income.Controls.Add(lblDescription_income);
            pnlCategory_Income.Controls.Add(tbIncome_Income);
            pnlCategory_Income.Controls.Add(lblIncome_Income);
            pnlCategory_Income.Controls.Add(tbItem_Income);
            pnlCategory_Income.Controls.Add(lblItem_Income);
            pnlCategory_Income.Controls.Add(cbCategory_Income);
            pnlCategory_Income.Controls.Add(lblCatogory_Income);
            pnlCategory_Income.Location = new Point(18, 424);
            pnlCategory_Income.Name = "pnlCategory_Income";
            pnlCategory_Income.Size = new Size(1201, 298);
            pnlCategory_Income.TabIndex = 1;
            // 
            // tbItem_Income
            // 
            tbItem_Income.BorderStyle = BorderStyle.FixedSingle;
            tbItem_Income.Location = new Point(145, 95);
            tbItem_Income.Name = "tbItem_Income";
            tbItem_Income.Size = new Size(263, 27);
            tbItem_Income.TabIndex = 4;
            // 
            // lblItem_Income
            // 
            lblItem_Income.AutoSize = true;
            lblItem_Income.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItem_Income.Location = new Point(73, 94);
            lblItem_Income.Name = "lblItem_Income";
            lblItem_Income.Size = new Size(59, 25);
            lblItem_Income.TabIndex = 3;
            lblItem_Income.Text = "Item:";
            // 
            // cbCategory_Income
            // 
            cbCategory_Income.FormattingEnabled = true;
            cbCategory_Income.Location = new Point(145, 30);
            cbCategory_Income.Name = "cbCategory_Income";
            cbCategory_Income.Size = new Size(263, 28);
            cbCategory_Income.TabIndex = 2;
            // 
            // lblCatogory_Income
            // 
            lblCatogory_Income.AutoSize = true;
            lblCatogory_Income.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCatogory_Income.Location = new Point(48, 30);
            lblCatogory_Income.Name = "lblCatogory_Income";
            lblCatogory_Income.Size = new Size(91, 25);
            lblCatogory_Income.TabIndex = 1;
            lblCatogory_Income.Text = "Catagory:";
            // 
            // tbIncome_Income
            // 
            tbIncome_Income.BorderStyle = BorderStyle.FixedSingle;
            tbIncome_Income.Location = new Point(145, 157);
            tbIncome_Income.Name = "tbIncome_Income";
            tbIncome_Income.Size = new Size(263, 27);
            tbIncome_Income.TabIndex = 6;
            // 
            // lblIncome_Income
            // 
            lblIncome_Income.AutoSize = true;
            lblIncome_Income.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIncome_Income.Location = new Point(61, 157);
            lblIncome_Income.Name = "lblIncome_Income";
            lblIncome_Income.Size = new Size(78, 25);
            lblIncome_Income.TabIndex = 5;
            lblIncome_Income.Text = "Income:";
            // 
            // tbDescription_Income
            // 
            tbDescription_Income.BorderStyle = BorderStyle.FixedSingle;
            tbDescription_Income.Location = new Point(641, 30);
            tbDescription_Income.Multiline = true;
            tbDescription_Income.Name = "tbDescription_Income";
            tbDescription_Income.Size = new Size(452, 89);
            tbDescription_Income.TabIndex = 8;
            // 
            // lblDescription_income
            // 
            lblDescription_income.AutoSize = true;
            lblDescription_income.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription_income.Location = new Point(524, 33);
            lblDescription_income.Name = "lblDescription_income";
            lblDescription_income.Size = new Size(111, 25);
            lblDescription_income.TabIndex = 7;
            lblDescription_income.Text = "Description:";
            // 
            // lblDate_Income
            // 
            lblDate_Income.AutoSize = true;
            lblDate_Income.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate_Income.Location = new Point(577, 157);
            lblDate_Income.Name = "lblDate_Income";
            lblDate_Income.Size = new Size(58, 25);
            lblDate_Income.TabIndex = 9;
            lblDate_Income.Text = "Date:";
            // 
            // dtpIncome_Income
            // 
            dtpIncome_Income.Location = new Point(641, 157);
            dtpIncome_Income.Name = "dtpIncome_Income";
            dtpIncome_Income.Size = new Size(250, 27);
            dtpIncome_Income.TabIndex = 10;
            // 
            // btnUpdate_Income
            // 
            btnUpdate_Income.BackColor = Color.FromArgb(16, 97, 40);
            btnUpdate_Income.FlatAppearance.BorderSize = 0;
            btnUpdate_Income.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 97, 16);
            btnUpdate_Income.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 97, 16);
            btnUpdate_Income.FlatStyle = FlatStyle.Flat;
            btnUpdate_Income.Location = new Point(334, 225);
            btnUpdate_Income.Name = "btnUpdate_Income";
            btnUpdate_Income.Size = new Size(135, 54);
            btnUpdate_Income.TabIndex = 12;
            btnUpdate_Income.Text = "Update";
            btnUpdate_Income.UseVisualStyleBackColor = false;
            // 
            // btnAdd_Income
            // 
            btnAdd_Income.BackColor = Color.FromArgb(16, 97, 40);
            btnAdd_Income.FlatAppearance.BorderSize = 0;
            btnAdd_Income.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 97, 16);
            btnAdd_Income.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 97, 16);
            btnAdd_Income.FlatStyle = FlatStyle.Flat;
            btnAdd_Income.Location = new Point(145, 225);
            btnAdd_Income.Name = "btnAdd_Income";
            btnAdd_Income.Size = new Size(135, 54);
            btnAdd_Income.TabIndex = 11;
            btnAdd_Income.Text = "Add";
            btnAdd_Income.UseVisualStyleBackColor = false;
            // 
            // btnDelete_Income
            // 
            btnDelete_Income.BackColor = Color.FromArgb(16, 97, 40);
            btnDelete_Income.FlatAppearance.BorderSize = 0;
            btnDelete_Income.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 97, 16);
            btnDelete_Income.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 97, 16);
            btnDelete_Income.FlatStyle = FlatStyle.Flat;
            btnDelete_Income.Location = new Point(830, 225);
            btnDelete_Income.Name = "btnDelete_Income";
            btnDelete_Income.Size = new Size(135, 54);
            btnDelete_Income.TabIndex = 14;
            btnDelete_Income.Text = "Delete";
            btnDelete_Income.UseVisualStyleBackColor = false;
            // 
            // btnClear_Income
            // 
            btnClear_Income.BackColor = Color.FromArgb(16, 97, 40);
            btnClear_Income.FlatAppearance.BorderSize = 0;
            btnClear_Income.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 97, 16);
            btnClear_Income.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 97, 16);
            btnClear_Income.FlatStyle = FlatStyle.Flat;
            btnClear_Income.Location = new Point(641, 225);
            btnClear_Income.Name = "btnClear_Income";
            btnClear_Income.Size = new Size(135, 54);
            btnClear_Income.TabIndex = 13;
            btnClear_Income.Text = "Clear";
            btnClear_Income.UseVisualStyleBackColor = false;
            // 
            // Income
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlCategory_Income);
            Controls.Add(pnlIncomeList_Income);
            Name = "Income";
            Size = new Size(1235, 740);
            pnlIncomeList_Income.ResumeLayout(false);
            pnlIncomeList_Income.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlCategory_Income.ResumeLayout(false);
            pnlCategory_Income.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlIncomeList_Income;
        private Panel pnlCategory_Income;
        private Label lblIncomeList_Income;
        private Label lblCatogory_Income;
        private DataGridView dataGridView1;
        private ComboBox cbCategory_Income;
        private TextBox tbItem_Income;
        private Label lblItem_Income;
        private TextBox tbIncome_Income;
        private Label lblIncome_Income;
        private TextBox tbDescription_Income;
        private Label lblDescription_income;
        private Label lblDate_Income;
        private DateTimePicker dtpIncome_Income;
        private Button btnDelete_Income;
        private Button btnClear_Income;
        private Button btnUpdate_Income;
        private Button btnAdd_Income;
    }
}
