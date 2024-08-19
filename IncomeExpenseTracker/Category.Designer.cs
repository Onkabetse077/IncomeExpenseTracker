namespace IncomeExpenseTracker
{
    partial class Category
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnlCategory1_Category = new Panel();
            btnDelete_Category = new Button();
            btnClear_Category = new Button();
            btnUpdate_Category = new Button();
            btnAdd_Category = new Button();
            cbStatus_Category = new ComboBox();
            lblStatus_Category = new Label();
            cbType_Category = new ComboBox();
            lblType_Category = new Label();
            tbCategory_Category = new TextBox();
            lblCategory_Category = new Label();
            pnlCategory2_Category = new Panel();
            lblCatogoriesList_Category = new Label();
            dgvCategoriesList_Category = new DataGridView();
            pnlCategory1_Category.SuspendLayout();
            pnlCategory2_Category.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoriesList_Category).BeginInit();
            SuspendLayout();
            // 
            // pnlCategory1_Category
            // 
            pnlCategory1_Category.Controls.Add(btnDelete_Category);
            pnlCategory1_Category.Controls.Add(btnClear_Category);
            pnlCategory1_Category.Controls.Add(btnUpdate_Category);
            pnlCategory1_Category.Controls.Add(btnAdd_Category);
            pnlCategory1_Category.Controls.Add(cbStatus_Category);
            pnlCategory1_Category.Controls.Add(lblStatus_Category);
            pnlCategory1_Category.Controls.Add(cbType_Category);
            pnlCategory1_Category.Controls.Add(lblType_Category);
            pnlCategory1_Category.Controls.Add(tbCategory_Category);
            pnlCategory1_Category.Controls.Add(lblCategory_Category);
            pnlCategory1_Category.Location = new Point(19, 23);
            pnlCategory1_Category.Name = "pnlCategory1_Category";
            pnlCategory1_Category.Size = new Size(368, 693);
            pnlCategory1_Category.TabIndex = 0;
            // 
            // btnDelete_Category
            // 
            btnDelete_Category.BackColor = Color.FromArgb(16, 97, 40);
            btnDelete_Category.FlatAppearance.BorderSize = 0;
            btnDelete_Category.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 97, 16);
            btnDelete_Category.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 97, 16);
            btnDelete_Category.FlatStyle = FlatStyle.Flat;
            btnDelete_Category.Location = new Point(213, 437);
            btnDelete_Category.Name = "btnDelete_Category";
            btnDelete_Category.Size = new Size(135, 54);
            btnDelete_Category.TabIndex = 9;
            btnDelete_Category.Text = "Delete";
            btnDelete_Category.UseVisualStyleBackColor = false;
            // 
            // btnClear_Category
            // 
            btnClear_Category.BackColor = Color.FromArgb(16, 97, 40);
            btnClear_Category.FlatAppearance.BorderSize = 0;
            btnClear_Category.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 97, 16);
            btnClear_Category.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 97, 16);
            btnClear_Category.FlatStyle = FlatStyle.Flat;
            btnClear_Category.Location = new Point(24, 437);
            btnClear_Category.Name = "btnClear_Category";
            btnClear_Category.Size = new Size(135, 54);
            btnClear_Category.TabIndex = 8;
            btnClear_Category.Text = "Clear";
            btnClear_Category.UseVisualStyleBackColor = false;
            // 
            // btnUpdate_Category
            // 
            btnUpdate_Category.BackColor = Color.FromArgb(16, 97, 40);
            btnUpdate_Category.FlatAppearance.BorderSize = 0;
            btnUpdate_Category.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 97, 16);
            btnUpdate_Category.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 97, 16);
            btnUpdate_Category.FlatStyle = FlatStyle.Flat;
            btnUpdate_Category.Location = new Point(213, 343);
            btnUpdate_Category.Name = "btnUpdate_Category";
            btnUpdate_Category.Size = new Size(135, 54);
            btnUpdate_Category.TabIndex = 7;
            btnUpdate_Category.Text = "Update";
            btnUpdate_Category.UseVisualStyleBackColor = false;
            // 
            // btnAdd_Category
            // 
            btnAdd_Category.BackColor = Color.FromArgb(16, 97, 40);
            btnAdd_Category.FlatAppearance.BorderSize = 0;
            btnAdd_Category.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 97, 16);
            btnAdd_Category.FlatAppearance.MouseOverBackColor = Color.FromArgb(33, 97, 16);
            btnAdd_Category.FlatStyle = FlatStyle.Flat;
            btnAdd_Category.Location = new Point(24, 343);
            btnAdd_Category.Name = "btnAdd_Category";
            btnAdd_Category.Size = new Size(135, 54);
            btnAdd_Category.TabIndex = 6;
            btnAdd_Category.Text = "Add";
            btnAdd_Category.UseVisualStyleBackColor = false;
            btnAdd_Category.Click += btnAdd_Category_Click;
            // 
            // cbStatus_Category
            // 
            cbStatus_Category.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbStatus_Category.FormattingEnabled = true;
            cbStatus_Category.Items.AddRange(new object[] { "Active", "Inactive" });
            cbStatus_Category.Location = new Point(24, 275);
            cbStatus_Category.Name = "cbStatus_Category";
            cbStatus_Category.Size = new Size(324, 25);
            cbStatus_Category.TabIndex = 5;
            // 
            // lblStatus_Category
            // 
            lblStatus_Category.AutoSize = true;
            lblStatus_Category.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus_Category.Location = new Point(24, 247);
            lblStatus_Category.Name = "lblStatus_Category";
            lblStatus_Category.Size = new Size(66, 25);
            lblStatus_Category.TabIndex = 4;
            lblStatus_Category.Text = "Status";
            // 
            // cbType_Category
            // 
            cbType_Category.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbType_Category.FormattingEnabled = true;
            cbType_Category.Items.AddRange(new object[] { "Income", "Expenses" });
            cbType_Category.Location = new Point(24, 181);
            cbType_Category.Name = "cbType_Category";
            cbType_Category.Size = new Size(324, 25);
            cbType_Category.TabIndex = 3;
            // 
            // lblType_Category
            // 
            lblType_Category.AutoSize = true;
            lblType_Category.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblType_Category.Location = new Point(24, 153);
            lblType_Category.Name = "lblType_Category";
            lblType_Category.Size = new Size(52, 25);
            lblType_Category.TabIndex = 2;
            lblType_Category.Text = "Type";
            // 
            // tbCategory_Category
            // 
            tbCategory_Category.BorderStyle = BorderStyle.FixedSingle;
            tbCategory_Category.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCategory_Category.Location = new Point(24, 89);
            tbCategory_Category.Name = "tbCategory_Category";
            tbCategory_Category.Size = new Size(324, 25);
            tbCategory_Category.TabIndex = 0;
            // 
            // lblCategory_Category
            // 
            lblCategory_Category.AutoSize = true;
            lblCategory_Category.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory_Category.Location = new Point(24, 61);
            lblCategory_Category.Name = "lblCategory_Category";
            lblCategory_Category.Size = new Size(85, 25);
            lblCategory_Category.TabIndex = 0;
            lblCategory_Category.Text = "Category";
            // 
            // pnlCategory2_Category
            // 
            pnlCategory2_Category.Controls.Add(lblCatogoriesList_Category);
            pnlCategory2_Category.Controls.Add(dgvCategoriesList_Category);
            pnlCategory2_Category.Location = new Point(412, 24);
            pnlCategory2_Category.Name = "pnlCategory2_Category";
            pnlCategory2_Category.Size = new Size(798, 693);
            pnlCategory2_Category.TabIndex = 1;
            // 
            // lblCatogoriesList_Category
            // 
            lblCatogoriesList_Category.AutoSize = true;
            lblCatogoriesList_Category.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCatogoriesList_Category.Location = new Point(12, 18);
            lblCatogoriesList_Category.Name = "lblCatogoriesList_Category";
            lblCatogoriesList_Category.Size = new Size(136, 25);
            lblCatogoriesList_Category.TabIndex = 1;
            lblCatogoriesList_Category.Text = "Categories List";
            // 
            // dgvCategoriesList_Category
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 97, 16);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCategoriesList_Category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategoriesList_Category.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoriesList_Category.EnableHeadersVisualStyles = false;
            dgvCategoriesList_Category.Location = new Point(12, 60);
            dgvCategoriesList_Category.Name = "dgvCategoriesList_Category";
            dgvCategoriesList_Category.RowHeadersVisible = false;
            dgvCategoriesList_Category.RowHeadersWidth = 51;
            dgvCategoriesList_Category.Size = new Size(770, 619);
            dgvCategoriesList_Category.TabIndex = 0;
            // 
            // Category
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlCategory2_Category);
            Controls.Add(pnlCategory1_Category);
            Name = "Category";
            Size = new Size(1235, 740);
            pnlCategory1_Category.ResumeLayout(false);
            pnlCategory1_Category.PerformLayout();
            pnlCategory2_Category.ResumeLayout(false);
            pnlCategory2_Category.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoriesList_Category).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCategory1_Category;
        private Panel pnlCategory2_Category;
        private Label lblCategory_Category;
        private TextBox tbCategory_Category;
        private ComboBox cbType_Category;
        private Label lblType_Category;
        private ComboBox cbStatus_Category;
        private Label lblStatus_Category;
        private Button btnAdd_Category;
        private Button btnDelete_Category;
        private Button btnClear_Category;
        private Button btnUpdate_Category;
        private DataGridView dgvCategoriesList_Category;
        private Label lblCatogoriesList_Category;
    }
}
