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
            pnlCategory1 = new Panel();
            pnlCategory2 = new Panel();
            SuspendLayout();
            // 
            // pnlCategory1
            // 
            pnlCategory1.Location = new Point(19, 23);
            pnlCategory1.Name = "pnlCategory1";
            pnlCategory1.Size = new Size(368, 693);
            pnlCategory1.TabIndex = 0;
            // 
            // pnlCategory2
            // 
            pnlCategory2.Location = new Point(412, 24);
            pnlCategory2.Name = "pnlCategory2";
            pnlCategory2.Size = new Size(798, 693);
            pnlCategory2.TabIndex = 1;
            // 
            // Category
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlCategory2);
            Controls.Add(pnlCategory1);
            Name = "Category";
            Size = new Size(1235, 740);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCategory1;
        private Panel pnlCategory2;
    }
}
