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
            this.PnlNewBook = new System.Windows.Forms.Panel();
            this.TxtNBCount = new System.Windows.Forms.TextBox();
            this.LblNBCount = new System.Windows.Forms.Label();
            this.BtnNBClose = new System.Windows.Forms.Button();
            this.BtnAddNewBook = new System.Windows.Forms.Button();
            this.TxtNBPrice = new System.Windows.Forms.TextBox();
            this.LblNBPrice = new System.Windows.Forms.Label();
            this.TxtNBName = new System.Windows.Forms.TextBox();
            this.LblNCName = new System.Windows.Forms.Label();
            this.BtnNewBook = new System.Windows.Forms.Button();
            this.LblBooks = new System.Windows.Forms.Label();
            this.DgvBooks = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtSearchBook = new System.Windows.Forms.TextBox();
            this.LblSearchBook = new System.Windows.Forms.Label();
            this.PnlNewBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).BeginInit();
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
            this.BtnUpdateBook.Click += new System.EventHandler(this.BtnUpdateBook_Click);
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
            this.BtnDeleteBook.Click += new System.EventHandler(this.BtnDeleteBook_Click);
            // 
            // BtnBookUpd
            // 
            this.BtnBookUpd.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnBookUpd.Location = new System.Drawing.Point(216, 210);
            this.BtnBookUpd.Name = "BtnBookUpd";
            this.BtnBookUpd.Size = new System.Drawing.Size(126, 55);
            this.BtnBookUpd.TabIndex = 11;
            this.BtnBookUpd.Text = "Update Book Information";
            this.BtnBookUpd.UseVisualStyleBackColor = false;
            this.BtnBookUpd.Visible = false;
            this.BtnBookUpd.Click += new System.EventHandler(this.BtnBookUpd_Click);
            // 
            // PnlNewBook
            // 
            this.PnlNewBook.BackColor = System.Drawing.Color.Orange;
            this.PnlNewBook.Controls.Add(this.TxtNBCount);
            this.PnlNewBook.Controls.Add(this.LblNBCount);
            this.PnlNewBook.Controls.Add(this.BtnBookUpd);
            this.PnlNewBook.Controls.Add(this.BtnNBClose);
            this.PnlNewBook.Controls.Add(this.BtnAddNewBook);
            this.PnlNewBook.Controls.Add(this.TxtNBPrice);
            this.PnlNewBook.Controls.Add(this.LblNBPrice);
            this.PnlNewBook.Controls.Add(this.TxtNBName);
            this.PnlNewBook.Controls.Add(this.LblNCName);
            this.PnlNewBook.Location = new System.Drawing.Point(219, 98);
            this.PnlNewBook.Name = "PnlNewBook";
            this.PnlNewBook.Size = new System.Drawing.Size(544, 359);
            this.PnlNewBook.TabIndex = 9;
            this.PnlNewBook.Visible = false;
            // 
            // TxtNBCount
            // 
            this.TxtNBCount.Location = new System.Drawing.Point(216, 168);
            this.TxtNBCount.Name = "TxtNBCount";
            this.TxtNBCount.Size = new System.Drawing.Size(126, 20);
            this.TxtNBCount.TabIndex = 13;
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
            // BtnNBClose
            // 
            this.BtnNBClose.BackColor = System.Drawing.Color.Red;
            this.BtnNBClose.Location = new System.Drawing.Point(466, 8);
            this.BtnNBClose.Name = "BtnNBClose";
            this.BtnNBClose.Size = new System.Drawing.Size(75, 23);
            this.BtnNBClose.TabIndex = 10;
            this.BtnNBClose.Text = "Close";
            this.BtnNBClose.UseVisualStyleBackColor = false;
            this.BtnNBClose.Click += new System.EventHandler(this.BtnNBClose_Click_1);
            // 
            // BtnAddNewBook
            // 
            this.BtnAddNewBook.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnAddNewBook.Location = new System.Drawing.Point(216, 210);
            this.BtnAddNewBook.Name = "BtnAddNewBook";
            this.BtnAddNewBook.Size = new System.Drawing.Size(126, 55);
            this.BtnAddNewBook.TabIndex = 8;
            this.BtnAddNewBook.Text = "Create New Book";
            this.BtnAddNewBook.UseVisualStyleBackColor = false;
            this.BtnAddNewBook.Click += new System.EventHandler(this.BtnAddNewBook_Click);
            // 
            // TxtNBPrice
            // 
            this.TxtNBPrice.Location = new System.Drawing.Point(216, 101);
            this.TxtNBPrice.Name = "TxtNBPrice";
            this.TxtNBPrice.Size = new System.Drawing.Size(126, 20);
            this.TxtNBPrice.TabIndex = 3;
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
            // TxtNBName
            // 
            this.TxtNBName.Location = new System.Drawing.Point(216, 40);
            this.TxtNBName.Name = "TxtNBName";
            this.TxtNBName.Size = new System.Drawing.Size(126, 20);
            this.TxtNBName.TabIndex = 1;
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
            this.BtnNewBook.Click += new System.EventHandler(this.BtnNewBook_Click);
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
            // DgvBooks
            // 
            this.DgvBooks.AllowUserToAddRows = false;
            this.DgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DgvBooks.Location = new System.Drawing.Point(219, 98);
            this.DgvBooks.Name = "DgvBooks";
            this.DgvBooks.Size = new System.Drawing.Size(544, 193);
            this.DgvBooks.TabIndex = 6;
            this.DgvBooks.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvBooks_RowHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Count";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            // 
            // TxtSearchBook
            // 
            this.TxtSearchBook.Location = new System.Drawing.Point(40, 366);
            this.TxtSearchBook.Name = "TxtSearchBook";
            this.TxtSearchBook.Size = new System.Drawing.Size(159, 20);
            this.TxtSearchBook.TabIndex = 15;
            this.TxtSearchBook.TextChanged += new System.EventHandler(this.TxtSearchBook_TextChanged);
            // 
            // LblSearchBook
            // 
            this.LblSearchBook.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearchBook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblSearchBook.Location = new System.Drawing.Point(53, 323);
            this.LblSearchBook.Name = "LblSearchBook";
            this.LblSearchBook.Size = new System.Drawing.Size(128, 40);
            this.LblSearchBook.TabIndex = 16;
            this.LblSearchBook.Text = "Search";
            this.LblSearchBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtSearchBook);
            this.Controls.Add(this.LblSearchBook);
            this.Controls.Add(this.BtnUpdateBook);
            this.Controls.Add(this.BtnDeleteBook);
            this.Controls.Add(this.PnlNewBook);
            this.Controls.Add(this.BtnNewBook);
            this.Controls.Add(this.LblBooks);
            this.Controls.Add(this.DgvBooks);
            this.Name = "Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
            this.PnlNewBook.ResumeLayout(false);
            this.PnlNewBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUpdateBook;
        private System.Windows.Forms.Button BtnDeleteBook;
        private System.Windows.Forms.Button BtnBookUpd;
        private System.Windows.Forms.Panel PnlNewBook;
        private System.Windows.Forms.Button BtnNBClose;
        private System.Windows.Forms.Button BtnAddNewBook;
        private System.Windows.Forms.TextBox TxtNBPrice;
        private System.Windows.Forms.Label LblNBPrice;
        private System.Windows.Forms.TextBox TxtNBName;
        private System.Windows.Forms.Label LblNCName;
        private System.Windows.Forms.Button BtnNewBook;
        private System.Windows.Forms.Label LblBooks;
        private System.Windows.Forms.DataGridView DgvBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox TxtNBCount;
        private System.Windows.Forms.Label LblNBCount;
        private System.Windows.Forms.TextBox TxtSearchBook;
        private System.Windows.Forms.Label LblSearchBook;
    }
}