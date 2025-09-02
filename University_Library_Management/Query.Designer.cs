namespace WindowsFormsApp2
{
    partial class Query
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
            this.queryLabel = new System.Windows.Forms.Label();
            this.queryInput = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.executeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // queryLabel
            // 
            this.queryLabel.AutoSize = true;
            this.queryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.queryLabel.Location = new System.Drawing.Point(271, 96);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(81, 29);
            this.queryLabel.TabIndex = 0;
            this.queryLabel.Text = "Query";
            this.queryLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // queryInput
            // 
            this.queryInput.Location = new System.Drawing.Point(358, 29);
            this.queryInput.Multiline = true;
            this.queryInput.Name = "queryInput";
            this.queryInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.queryInput.Size = new System.Drawing.Size(330, 161);
            this.queryInput.TabIndex = 1;
            this.queryInput.TextChanged += new System.EventHandler(this.queryInput_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(982, 281);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // executeBtn
            // 
            this.executeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.executeBtn.Location = new System.Drawing.Point(707, 96);
            this.executeBtn.Name = "executeBtn";
            this.executeBtn.Size = new System.Drawing.Size(112, 40);
            this.executeBtn.TabIndex = 3;
            this.executeBtn.Text = "Execute";
            this.executeBtn.UseVisualStyleBackColor = true;
            this.executeBtn.Click += new System.EventHandler(this.executeBtn_Click);
            // 
            // Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 550);
            this.Controls.Add(this.executeBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.queryInput);
            this.Controls.Add(this.queryLabel);
            this.Name = "Query";
            this.Text = "Query";
            this.Load += new System.EventHandler(this.Query_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.TextBox queryInput;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button executeBtn;
    }
}