namespace WindowsFormsApp2
{
    partial class AddBook
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.catLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.bIdLabel = new System.Windows.Forms.Label();
            this.authorIdLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.nCopiesLabel = new System.Windows.Forms.Label();
            this.titletxt = new System.Windows.Forms.TextBox();
            this.isbntxt = new System.Windows.Forms.TextBox();
            this.ratetxt = new System.Windows.Forms.TextBox();
            this.desctxt = new System.Windows.Forms.TextBox();
            this.cattxt = new System.Windows.Forms.TextBox();
            this.authortxt = new System.Windows.Forms.TextBox();
            this.ncopytxt = new System.Windows.Forms.TextBox();
            this.authoridtxt = new System.Windows.Forms.TextBox();
            this.bookidtxt = new System.Windows.Forms.TextBox();
            this.yeartxt = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(106, 53);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(61, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(106, 118);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(82, 29);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "Author";
            // 
            // catLabel
            // 
            this.catLabel.AutoSize = true;
            this.catLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catLabel.Location = new System.Drawing.Point(91, 187);
            this.catLabel.Name = "catLabel";
            this.catLabel.Size = new System.Drawing.Size(110, 29);
            this.catLabel.TabIndex = 2;
            this.catLabel.Text = "Category";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLabel.Location = new System.Drawing.Point(70, 251);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(135, 29);
            this.descLabel.TabIndex = 3;
            this.descLabel.Text = "Description";
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateLabel.Location = new System.Drawing.Point(106, 312);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(63, 29);
            this.rateLabel.TabIndex = 4;
            this.rateLabel.Text = "Rate";
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnLabel.Location = new System.Drawing.Point(106, 370);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(69, 29);
            this.isbnLabel.TabIndex = 5;
            this.isbnLabel.Text = "ISBN";
            // 
            // bIdLabel
            // 
            this.bIdLabel.AutoSize = true;
            this.bIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bIdLabel.Location = new System.Drawing.Point(106, 433);
            this.bIdLabel.Name = "bIdLabel";
            this.bIdLabel.Size = new System.Drawing.Size(95, 29);
            this.bIdLabel.TabIndex = 6;
            this.bIdLabel.Text = "Book Id";
            // 
            // authorIdLabel
            // 
            this.authorIdLabel.AutoSize = true;
            this.authorIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorIdLabel.Location = new System.Drawing.Point(106, 490);
            this.authorIdLabel.Name = "authorIdLabel";
            this.authorIdLabel.Size = new System.Drawing.Size(108, 29);
            this.authorIdLabel.TabIndex = 7;
            this.authorIdLabel.Text = "Author Id";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(36, 614);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(178, 29);
            this.yearLabel.TabIndex = 8;
            this.yearLabel.Text = "Published Year";
            // 
            // nCopiesLabel
            // 
            this.nCopiesLabel.AutoSize = true;
            this.nCopiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nCopiesLabel.Location = new System.Drawing.Point(12, 554);
            this.nCopiesLabel.Name = "nCopiesLabel";
            this.nCopiesLabel.Size = new System.Drawing.Size(214, 29);
            this.nCopiesLabel.TabIndex = 9;
            this.nCopiesLabel.Text = "Number Of Copies";
            // 
            // titletxt
            // 
            this.titletxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titletxt.Location = new System.Drawing.Point(226, 48);
            this.titletxt.Name = "titletxt";
            this.titletxt.Size = new System.Drawing.Size(364, 34);
            this.titletxt.TabIndex = 10;
            // 
            // isbntxt
            // 
            this.isbntxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbntxt.Location = new System.Drawing.Point(226, 367);
            this.isbntxt.Name = "isbntxt";
            this.isbntxt.Size = new System.Drawing.Size(364, 34);
            this.isbntxt.TabIndex = 11;
            // 
            // ratetxt
            // 
            this.ratetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratetxt.Location = new System.Drawing.Point(226, 307);
            this.ratetxt.Name = "ratetxt";
            this.ratetxt.Size = new System.Drawing.Size(364, 34);
            this.ratetxt.TabIndex = 12;
            // 
            // desctxt
            // 
            this.desctxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desctxt.Location = new System.Drawing.Point(226, 251);
            this.desctxt.Name = "desctxt";
            this.desctxt.Size = new System.Drawing.Size(364, 34);
            this.desctxt.TabIndex = 13;
            // 
            // cattxt
            // 
            this.cattxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cattxt.Location = new System.Drawing.Point(226, 187);
            this.cattxt.Name = "cattxt";
            this.cattxt.Size = new System.Drawing.Size(364, 34);
            this.cattxt.TabIndex = 14;
            // 
            // authortxt
            // 
            this.authortxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authortxt.Location = new System.Drawing.Point(226, 118);
            this.authortxt.Name = "authortxt";
            this.authortxt.Size = new System.Drawing.Size(364, 34);
            this.authortxt.TabIndex = 15;
            // 
            // ncopytxt
            // 
            this.ncopytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncopytxt.Location = new System.Drawing.Point(226, 549);
            this.ncopytxt.Name = "ncopytxt";
            this.ncopytxt.Size = new System.Drawing.Size(364, 34);
            this.ncopytxt.TabIndex = 16;
            // 
            // authoridtxt
            // 
            this.authoridtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authoridtxt.Location = new System.Drawing.Point(226, 485);
            this.authoridtxt.Name = "authoridtxt";
            this.authoridtxt.Size = new System.Drawing.Size(364, 34);
            this.authoridtxt.TabIndex = 17;
            // 
            // bookidtxt
            // 
            this.bookidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookidtxt.Location = new System.Drawing.Point(226, 430);
            this.bookidtxt.Name = "bookidtxt";
            this.bookidtxt.Size = new System.Drawing.Size(364, 34);
            this.bookidtxt.TabIndex = 18;
            // 
            // yeartxt
            // 
            this.yeartxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yeartxt.Location = new System.Drawing.Point(226, 609);
            this.yeartxt.Name = "yeartxt";
            this.yeartxt.Size = new System.Drawing.Size(364, 34);
            this.yeartxt.TabIndex = 19;
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(300, 686);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(117, 53);
            this.addbtn.TabIndex = 20;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 774);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.yeartxt);
            this.Controls.Add(this.bookidtxt);
            this.Controls.Add(this.authoridtxt);
            this.Controls.Add(this.ncopytxt);
            this.Controls.Add(this.authortxt);
            this.Controls.Add(this.cattxt);
            this.Controls.Add(this.desctxt);
            this.Controls.Add(this.ratetxt);
            this.Controls.Add(this.isbntxt);
            this.Controls.Add(this.titletxt);
            this.Controls.Add(this.nCopiesLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.authorIdLabel);
            this.Controls.Add(this.bIdLabel);
            this.Controls.Add(this.isbnLabel);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.catLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "AddBook";
            this.Text = "Add Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label catLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.Label isbnLabel;
        private System.Windows.Forms.Label bIdLabel;
        private System.Windows.Forms.Label authorIdLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label nCopiesLabel;
        private System.Windows.Forms.TextBox titletxt;
        private System.Windows.Forms.TextBox isbntxt;
        private System.Windows.Forms.TextBox ratetxt;
        private System.Windows.Forms.TextBox desctxt;
        private System.Windows.Forms.TextBox cattxt;
        private System.Windows.Forms.TextBox authortxt;
        private System.Windows.Forms.TextBox ncopytxt;
        private System.Windows.Forms.TextBox authoridtxt;
        private System.Windows.Forms.TextBox bookidtxt;
        private System.Windows.Forms.TextBox yeartxt;
        private System.Windows.Forms.Button addbtn;
    }
}