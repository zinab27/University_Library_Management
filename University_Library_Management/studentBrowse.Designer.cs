namespace WindowsFormsApp2
{
    partial class studentBrowse
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
            this.booksTable = new System.Windows.Forms.DataGridView();
            this.borrowBtn = new System.Windows.Forms.Button();
            this.showborrwedbtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.booksTable)).BeginInit();
            this.SuspendLayout();
            // 
            // booksTable
            // 
            this.booksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksTable.Location = new System.Drawing.Point(25, 32);
            this.booksTable.Name = "booksTable";
            this.booksTable.RowHeadersWidth = 51;
            this.booksTable.RowTemplate.Height = 24;
            this.booksTable.Size = new System.Drawing.Size(1243, 312);
            this.booksTable.TabIndex = 0;
            this.booksTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksTable_CellContentClick);
            // 
            // borrowBtn
            // 
            this.borrowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.borrowBtn.Location = new System.Drawing.Point(340, 359);
            this.borrowBtn.Name = "borrowBtn";
            this.borrowBtn.Size = new System.Drawing.Size(172, 61);
            this.borrowBtn.TabIndex = 1;
            this.borrowBtn.Text = "Borrow";
            this.borrowBtn.UseVisualStyleBackColor = true;
            this.borrowBtn.Click += new System.EventHandler(this.borrowBtn_Click);
            // 
            // showborrwedbtn
            // 
            this.showborrwedbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.showborrwedbtn.Location = new System.Drawing.Point(644, 359);
            this.showborrwedbtn.Name = "showborrwedbtn";
            this.showborrwedbtn.Size = new System.Drawing.Size(388, 61);
            this.showborrwedbtn.TabIndex = 2;
            this.showborrwedbtn.Text = "Show borrowed books";
            this.showborrwedbtn.UseVisualStyleBackColor = true;
            this.showborrwedbtn.Click += new System.EventHandler(this.showborrwedbtn_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.logoutbtn.Location = new System.Drawing.Point(52, 359);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(172, 61);
            this.logoutbtn.TabIndex = 3;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // studentBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 450);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.showborrwedbtn);
            this.Controls.Add(this.borrowBtn);
            this.Controls.Add(this.booksTable);
            this.Name = "studentBrowse";
            this.Text = "Browse Books";
            this.Load += new System.EventHandler(this.studentBrowse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView booksTable;
        private System.Windows.Forms.Button borrowBtn;
        private System.Windows.Forms.Button showborrwedbtn;
        private System.Windows.Forms.Button logoutbtn;
    }
}