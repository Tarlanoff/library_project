namespace library_project.Forms
{
    partial class Books
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
            this.BtnUpdateBook = new System.Windows.Forms.Button();
            this.BtnDeleteBook = new System.Windows.Forms.Button();
            this.BtnBookUpd = new System.Windows.Forms.Button();
            this.PnlAddNC = new System.Windows.Forms.Panel();
            this.BtnNCClose = new System.Windows.Forms.Button();
            this.BtnAddNB = new System.Windows.Forms.Button();
            this.TxtNCSurname = new System.Windows.Forms.TextBox();
            this.LblNBPrice = new System.Windows.Forms.Label();
            this.TxtNCName = new System.Windows.Forms.TextBox();
            this.LblNCName = new System.Windows.Forms.Label();
            this.BtnNewBook = new System.Windows.Forms.Button();
            this.LblBooks = new System.Windows.Forms.Label();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvCustomers = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblNBCount = new System.Windows.Forms.Label();
            this.PnlAddNC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnUpdateBook
            // 
            this.BtnUpdateBook.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnUpdateBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnUpdateBook.Location = new System.Drawing.Point(40, 244);
            this.BtnUpdateBook.Name = "BtnUpdateBook";
            this.BtnUpdateBook.Size = new System.Drawing.Size(159, 59);
            this.BtnUpdateBook.TabIndex = 11;
            this.BtnUpdateBook.Text = "Update Book Info";
            this.BtnUpdateBook.UseVisualStyleBackColor = false;
            // 
            // BtnDeleteBook
            // 
            this.BtnDeleteBook.BackColor = System.Drawing.Color.Red;
            this.BtnDeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDeleteBook.Location = new System.Drawing.Point(40, 165);
            this.BtnDeleteBook.Name = "BtnDeleteBook";
            this.BtnDeleteBook.Size = new System.Drawing.Size(159, 59);
            this.BtnDeleteBook.TabIndex = 10;
            this.BtnDeleteBook.Text = "Delete Book";
            this.BtnDeleteBook.UseVisualStyleBackColor = false;
            // 
            // BtnBookUpd
            // 
            this.BtnBookUpd.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnBookUpd.Location = new System.Drawing.Point(216, 271);
            this.BtnBookUpd.Name = "BtnBookUpd";
            this.BtnBookUpd.Size = new System.Drawing.Size(126, 55);
            this.BtnBookUpd.TabIndex = 11;
            this.BtnBookUpd.Text = "Update Book Information";
            this.BtnBookUpd.UseVisualStyleBackColor = false;
            this.BtnBookUpd.Visible = false;
            // 
            // PnlAddNC
            // 
            this.PnlAddNC.BackColor = System.Drawing.Color.Orange;
            this.PnlAddNC.Controls.Add(this.textBox1);
            this.PnlAddNC.Controls.Add(this.LblNBCount);
            this.PnlAddNC.Controls.Add(this.BtnBookUpd);
            this.PnlAddNC.Controls.Add(this.BtnNCClose);
            this.PnlAddNC.Controls.Add(this.BtnAddNB);
            this.PnlAddNC.Controls.Add(this.TxtNCSurname);
            this.PnlAddNC.Controls.Add(this.LblNBPrice);
            this.PnlAddNC.Controls.Add(this.TxtNCName);
            this.PnlAddNC.Controls.Add(this.LblNCName);
            this.PnlAddNC.Location = new System.Drawing.Point(216, 75);
            this.PnlAddNC.Name = "PnlAddNC";
            this.PnlAddNC.Size = new System.Drawing.Size(544, 359);
            this.PnlAddNC.TabIndex = 9;
            this.PnlAddNC.Visible = false;
            // 
            // BtnNCClose
            // 
            this.BtnNCClose.BackColor = System.Drawing.Color.Red;
            this.BtnNCClose.Location = new System.Drawing.Point(466, 8);
            this.BtnNCClose.Name = "BtnNCClose";
            this.BtnNCClose.Size = new System.Drawing.Size(75, 23);
            this.BtnNCClose.TabIndex = 10;
            this.BtnNCClose.Text = "Close";
            this.BtnNCClose.UseVisualStyleBackColor = false;
            // 
            // BtnAddNB
            // 
            this.BtnAddNB.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnAddNB.Location = new System.Drawing.Point(216, 210);
            this.BtnAddNB.Name = "BtnAddNB";
            this.BtnAddNB.Size = new System.Drawing.Size(126, 55);
            this.BtnAddNB.TabIndex = 8;
            this.BtnAddNB.Text = "Create New Book";
            this.BtnAddNB.UseVisualStyleBackColor = false;
            // 
            // TxtNCSurname
            // 
            this.TxtNCSurname.Location = new System.Drawing.Point(216, 101);
            this.TxtNCSurname.Name = "TxtNCSurname";
            this.TxtNCSurname.Size = new System.Drawing.Size(126, 20);
            this.TxtNCSurname.TabIndex = 3;
            // 
            // LblNBPrice
            // 
            this.LblNBPrice.AutoSize = true;
            this.LblNBPrice.Location = new System.Drawing.Point(213, 75);
            this.LblNBPrice.Name = "LblNBPrice";
            this.LblNBPrice.Size = new System.Drawing.Size(31, 13);
            this.LblNBPrice.TabIndex = 2;
            this.LblNBPrice.Text = "Price";
            // 
            // TxtNCName
            // 
            this.TxtNCName.Location = new System.Drawing.Point(216, 40);
            this.TxtNCName.Name = "TxtNCName";
            this.TxtNCName.Size = new System.Drawing.Size(126, 20);
            this.TxtNCName.TabIndex = 1;
            // 
            // LblNCName
            // 
            this.LblNCName.AutoSize = true;
            this.LblNCName.Location = new System.Drawing.Point(213, 14);
            this.LblNCName.Name = "LblNCName";
            this.LblNCName.Size = new System.Drawing.Size(35, 13);
            this.LblNCName.TabIndex = 0;
            this.LblNCName.Text = "Name";
            // 
            // BtnNewBook
            // 
            this.BtnNewBook.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnNewBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnNewBook.Location = new System.Drawing.Point(40, 98);
            this.BtnNewBook.Name = "BtnNewBook";
            this.BtnNewBook.Size = new System.Drawing.Size(159, 55);
            this.BtnNewBook.TabIndex = 8;
            this.BtnNewBook.Text = "New Book";
            this.BtnNewBook.UseVisualStyleBackColor = false;
            // 
            // LblBooks
            // 
            this.LblBooks.AutoSize = true;
            this.LblBooks.BackColor = System.Drawing.Color.Transparent;
            this.LblBooks.Font = new System.Drawing.Font("Papyrus", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBooks.ForeColor = System.Drawing.Color.OrangeRed;
            this.LblBooks.Location = new System.Drawing.Point(324, 17);
            this.LblBooks.Name = "LblBooks";
            this.LblBooks.Size = new System.Drawing.Size(136, 55);
            this.LblBooks.TabIndex = 7;
            this.LblBooks.Text = "Books";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Birthday";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Phone Number";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Surname";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "CreatedAt";
            this.Column6.Name = "Column6";
            // 
            // DgvCustomers
            // 
            this.DgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DgvCustomers.Location = new System.Drawing.Point(216, 98);
            this.DgvCustomers.Name = "DgvCustomers";
            this.DgvCustomers.Size = new System.Drawing.Size(544, 193);
            this.DgvCustomers.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(220, 162);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 13;
            // 
            // LblNBCount
            // 
            this.LblNBCount.AutoSize = true;
            this.LblNBCount.Location = new System.Drawing.Point(217, 136);
            this.LblNBCount.Name = "LblNBCount";
            this.LblNBCount.Size = new System.Drawing.Size(35, 13);
            this.LblNBCount.TabIndex = 12;
            this.LblNBCount.Text = "Count";
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnUpdateBook);
            this.Controls.Add(this.BtnDeleteBook);
            this.Controls.Add(this.PnlAddNC);
            this.Controls.Add(this.BtnNewBook);
            this.Controls.Add(this.LblBooks);
            this.Controls.Add(this.DgvCustomers);
            this.Name = "Books";
            this.Text = "Books";
            this.PnlAddNC.ResumeLayout(false);
            this.PnlAddNC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUpdateBook;
        private System.Windows.Forms.Button BtnDeleteBook;
        private System.Windows.Forms.Button BtnBookUpd;
        private System.Windows.Forms.Panel PnlAddNC;
        private System.Windows.Forms.Button BtnNCClose;
        private System.Windows.Forms.Button BtnAddNB;
        private System.Windows.Forms.TextBox TxtNCSurname;
        private System.Windows.Forms.Label LblNBPrice;
        private System.Windows.Forms.TextBox TxtNCName;
        private System.Windows.Forms.Label LblNCName;
        private System.Windows.Forms.Button BtnNewBook;
        private System.Windows.Forms.Label LblBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridView DgvCustomers;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblNBCount;
    }
}