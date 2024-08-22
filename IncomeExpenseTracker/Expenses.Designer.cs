namespace IncomeExpenseTracker
{
    partial class Expenses
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
            pnlCategory_Expense = new Panel();
            btnDelete_Expense = new Button();
            btnClear_Expense = new Button();
            btnUpdate_Expense = new Button();
            btnAdd_Expense = new Button();
            dtpExpense_Expense = new DateTimePicker();
            lblDate_Expense = new Label();
            tbDescription_Expense = new TextBox();
            lblDescription_Expense = new Label();
            tbExpense_Expense = new TextBox();
            lblExpense_Expense = new Label();
            tbItem_Expense = new TextBox();
            lblItem_Expense = new Label();
            cbCategory_Expense = new ComboBox();
            lblCatogory_Expense = new Label();
            pnlExpenseList_Expense = new Panel();
            dgvExpense_Expense = new DataGridView();
            lblExpenseList_Expense = new Label();
            pnlCategory_Expense.SuspendLayout();
            pnlExpenseList_Expense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpense_Expense).BeginInit();
            SuspendLayout();
            // 
            // pnlCategory_Expense
            // 
            pnlCategory_Expense.Controls.Add(btnDelete_Expense);
            pnlCategory_Expense.Controls.Add(btnClear_Expense);
            pnlCategory_Expense.Controls.Add(btnUpdate_Expense);
            pnlCategory_Expense.Controls.Add(btnAdd_Expense);
            pnlCategory_Expense.Controls.Add(dtpExpense_Expense);
            pnlCategory_Expense.Controls.Add(lblDate_Expense);
            pnlCategory_Expense.Controls.Add(tbDescription_Expense);
            pnlCategory_Expense.Controls.Add(lblDescription_Expense);
            pnlCategory_Expense.Controls.Add(tbExpense_Expense);
            pnlCategory_Expense.Controls.Add(lblExpense_Expense);
            pnlCategory_Expense.Controls.Add(tbItem_Expense);
            pnlCategory_Expense.Controls.Add(lblItem_Expense);
            pnlCategory_Expense.Controls.Add(cbCategory_Expense);
            pnlCategory_Expense.Controls.Add(lblCatogory_Expense);
            pnlCategory_Expense.Location = new Point(17, 418);
            pnlCategory_Expense.Name = "pnlCategory_Expense";
            pnlCategory_Expense.Size = new Size(1201, 298);
            pnlCategory_Expense.TabIndex = 3;
            // 
            // btnDelete_Expense
            // 
            btnDelete_Expense.BackColor = Color.FromArgb(16, 97, 40);
            btnDelete_Expense.FlatAppearance.BorderSize = 0;
            btnDelete_Expense.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 97, 16);
            btnDelete_Expense.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 97, 16);
            btnDelete_Expense.FlatStyle = FlatStyle.Flat;
            btnDelete_Expense.Location = new Point(830, 225);
            btnDelete_Expense.Name = "btnDelete_Expense";
            btnDelete_Expense.Size = new Size(135, 54);
            btnDelete_Expense.TabIndex = 14;
            btnDelete_Expense.Text = "Delete";
            btnDelete_Expense.UseVisualStyleBackColor = false;
            btnDelete_Expense.Click += btnDelete_Expense_Click;
            // 
            // btnClear_Expense
            // 
            btnClear_Expense.BackColor = Color.FromArgb(16, 97, 40);
            btnClear_Expense.FlatAppearance.BorderSize = 0;
            btnClear_Expense.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 97, 16);
            btnClear_Expense.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 97, 16);
            btnClear_Expense.FlatStyle = FlatStyle.Flat;
            btnClear_Expense.Location = new Point(641, 225);
            btnClear_Expense.Name = "btnClear_Expense";
            btnClear_Expense.Size = new Size(135, 54);
            btnClear_Expense.TabIndex = 13;
            btnClear_Expense.Text = "Clear";
            btnClear_Expense.UseVisualStyleBackColor = false;
            btnClear_Expense.Click += btnClear_Expense_Click;
            // 
            // btnUpdate_Expense
            // 
            btnUpdate_Expense.BackColor = Color.FromArgb(16, 97, 40);
            btnUpdate_Expense.FlatAppearance.BorderSize = 0;
            btnUpdate_Expense.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 97, 16);
            btnUpdate_Expense.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 97, 16);
            btnUpdate_Expense.FlatStyle = FlatStyle.Flat;
            btnUpdate_Expense.Location = new Point(334, 225);
            btnUpdate_Expense.Name = "btnUpdate_Expense";
            btnUpdate_Expense.Size = new Size(135, 54);
            btnUpdate_Expense.TabIndex = 12;
            btnUpdate_Expense.Text = "Update";
            btnUpdate_Expense.UseVisualStyleBackColor = false;
            btnUpdate_Expense.Click += btnUpdate_Expense_Click;
            // 
            // btnAdd_Expense
            // 
            btnAdd_Expense.BackColor = Color.FromArgb(16, 97, 40);
            btnAdd_Expense.FlatAppearance.BorderSize = 0;
            btnAdd_Expense.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 97, 16);
            btnAdd_Expense.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 97, 16);
            btnAdd_Expense.FlatStyle = FlatStyle.Flat;
            btnAdd_Expense.Location = new Point(145, 225);
            btnAdd_Expense.Name = "btnAdd_Expense";
            btnAdd_Expense.Size = new Size(135, 54);
            btnAdd_Expense.TabIndex = 11;
            btnAdd_Expense.Text = "Add";
            btnAdd_Expense.UseVisualStyleBackColor = false;
            btnAdd_Expense.Click += btnAdd_Expense_Click;
            // 
            // dtpExpense_Expense
            // 
            dtpExpense_Expense.Location = new Point(641, 157);
            dtpExpense_Expense.Name = "dtpExpense_Expense";
            dtpExpense_Expense.Size = new Size(250, 27);
            dtpExpense_Expense.TabIndex = 10;
            // 
            // lblDate_Expense
            // 
            lblDate_Expense.AutoSize = true;
            lblDate_Expense.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate_Expense.Location = new Point(577, 157);
            lblDate_Expense.Name = "lblDate_Expense";
            lblDate_Expense.Size = new Size(58, 25);
            lblDate_Expense.TabIndex = 9;
            lblDate_Expense.Text = "Date:";
            // 
            // tbDescription_Expense
            // 
            tbDescription_Expense.BorderStyle = BorderStyle.FixedSingle;
            tbDescription_Expense.Location = new Point(641, 30);
            tbDescription_Expense.Multiline = true;
            tbDescription_Expense.Name = "tbDescription_Expense";
            tbDescription_Expense.Size = new Size(452, 89);
            tbDescription_Expense.TabIndex = 8;
            // 
            // lblDescription_Expense
            // 
            lblDescription_Expense.AutoSize = true;
            lblDescription_Expense.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription_Expense.Location = new Point(524, 33);
            lblDescription_Expense.Name = "lblDescription_Expense";
            lblDescription_Expense.Size = new Size(111, 25);
            lblDescription_Expense.TabIndex = 7;
            lblDescription_Expense.Text = "Description:";
            // 
            // tbExpense_Expense
            // 
            tbExpense_Expense.BorderStyle = BorderStyle.FixedSingle;
            tbExpense_Expense.Location = new Point(145, 157);
            tbExpense_Expense.Name = "tbExpense_Expense";
            tbExpense_Expense.Size = new Size(263, 27);
            tbExpense_Expense.TabIndex = 6;
            // 
            // lblExpense_Expense
            // 
            lblExpense_Expense.AutoSize = true;
            lblExpense_Expense.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpense_Expense.Location = new Point(61, 157);
            lblExpense_Expense.Name = "lblExpense_Expense";
            lblExpense_Expense.Size = new Size(86, 25);
            lblExpense_Expense.TabIndex = 5;
            lblExpense_Expense.Text = "Expense:";
            // 
            // tbItem_Expense
            // 
            tbItem_Expense.BorderStyle = BorderStyle.FixedSingle;
            tbItem_Expense.Location = new Point(145, 95);
            tbItem_Expense.Name = "tbItem_Expense";
            tbItem_Expense.Size = new Size(263, 27);
            tbItem_Expense.TabIndex = 4;
            // 
            // lblItem_Expense
            // 
            lblItem_Expense.AutoSize = true;
            lblItem_Expense.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItem_Expense.Location = new Point(73, 94);
            lblItem_Expense.Name = "lblItem_Expense";
            lblItem_Expense.Size = new Size(59, 25);
            lblItem_Expense.TabIndex = 3;
            lblItem_Expense.Text = "Item:";
            // 
            // cbCategory_Expense
            // 
            cbCategory_Expense.FormattingEnabled = true;
            cbCategory_Expense.Location = new Point(145, 30);
            cbCategory_Expense.Name = "cbCategory_Expense";
            cbCategory_Expense.Size = new Size(263, 28);
            cbCategory_Expense.TabIndex = 2;
            // 
            // lblCatogory_Expense
            // 
            lblCatogory_Expense.AutoSize = true;
            lblCatogory_Expense.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCatogory_Expense.Location = new Point(48, 30);
            lblCatogory_Expense.Name = "lblCatogory_Expense";
            lblCatogory_Expense.Size = new Size(91, 25);
            lblCatogory_Expense.TabIndex = 1;
            lblCatogory_Expense.Text = "Catagory:";
            // 
            // pnlExpenseList_Expense
            // 
            pnlExpenseList_Expense.Controls.Add(dgvExpense_Expense);
            pnlExpenseList_Expense.Controls.Add(lblExpenseList_Expense);
            pnlExpenseList_Expense.Location = new Point(17, 24);
            pnlExpenseList_Expense.Name = "pnlExpenseList_Expense";
            pnlExpenseList_Expense.Size = new Size(1201, 375);
            pnlExpenseList_Expense.TabIndex = 2;
            // 
            // dgvExpense_Expense
            // 
            dgvExpense_Expense.AllowUserToAddRows = false;
            dgvExpense_Expense.AllowUserToDeleteRows = false;
            dgvExpense_Expense.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExpense_Expense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpense_Expense.Location = new Point(25, 46);
            dgvExpense_Expense.Name = "dgvExpense_Expense";
            dgvExpense_Expense.ReadOnly = true;
            dgvExpense_Expense.RowHeadersWidth = 51;
            dgvExpense_Expense.Size = new Size(1154, 306);
            dgvExpense_Expense.TabIndex = 1;
            // 
            // lblExpenseList_Expense
            // 
            lblExpenseList_Expense.AutoSize = true;
            lblExpenseList_Expense.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpenseList_Expense.Location = new Point(25, 18);
            lblExpenseList_Expense.Name = "lblExpenseList_Expense";
            lblExpenseList_Expense.Size = new Size(116, 25);
            lblExpenseList_Expense.TabIndex = 0;
            lblExpenseList_Expense.Text = "Expense List";
            // 
            // Expenses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlCategory_Expense);
            Controls.Add(pnlExpenseList_Expense);
            Name = "Expenses";
            Size = new Size(1235, 740);
            pnlCategory_Expense.ResumeLayout(false);
            pnlCategory_Expense.PerformLayout();
            pnlExpenseList_Expense.ResumeLayout(false);
            pnlExpenseList_Expense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpense_Expense).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCategory_Expense;
        private Button btnDelete_Expense;
        private Button btnClear_Expense;
        private Button btnUpdate_Expense;
        private Button btnAdd_Expense;
        private DateTimePicker dtpExpense_Expense;
        private Label lblDate_Expense;
        private TextBox tbDescription_Expense;
        private Label lblDescription_Expense;
        private TextBox tbExpense_Expense;
        private Label lblExpense_Expense;
        private TextBox tbItem_Expense;
        private Label lblItem_Expense;
        private ComboBox cbCategory_Expense;
        private Label lblCatogory_Expense;
        private Panel pnlExpenseList_Expense;
        private DataGridView dgvExpense_Expense;
        private Label lblExpenseList_Expense;
    }
}
