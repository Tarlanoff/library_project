namespace library_project.Forms
{
    partial class Dashboard
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
            this.BtnNewOrder = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.PnlNewOrder = new System.Windows.Forms.Panel();
            this.DTPReturnTime = new System.Windows.Forms.DateTimePicker();
            this.BtnNOAccept = new System.Windows.Forms.Button();
            this.LblBook = new System.Windows.Forms.Label();
            this.LblReturnTime = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.CmbNOBook = new System.Windows.Forms.ComboBox();
            this.CmbNOCustomer = new System.Windows.Forms.ComboBox();
            this.LblCustomer = new System.Windows.Forms.Label();
            this.BtnCustomers = new System.Windows.Forms.Button();
            this.BtnBooks = new System.Windows.Forms.Button();
            this.PnlNewOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnNewOrder
            // 
            this.BtnNewOrder.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnNewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnNewOrder.Location = new System.Drawing.Point(12, 43);
            this.BtnNewOrder.Name = "BtnNewOrder";
            this.BtnNewOrder.Size = new System.Drawing.Size(139, 47);
            this.BtnNewOrder.TabIndex = 0;
            this.BtnNewOrder.Text = "New Order";
            this.BtnNewOrder.UseVisualStyleBackColor = false;
            this.BtnNewOrder.Click += new System.EventHandler(this.BtnNewOrder_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnLogout.Location = new System.Drawing.Point(12, 618);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(139, 47);
            this.BtnLogout.TabIndex = 1;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // PnlNewOrder
            // 
            this.PnlNewOrder.BackColor = System.Drawing.Color.Transparent;
            this.PnlNewOrder.Controls.Add(this.DTPReturnTime);
            this.PnlNewOrder.Controls.Add(this.BtnNOAccept);
            this.PnlNewOrder.Controls.Add(this.LblBook);
            this.PnlNewOrder.Controls.Add(this.LblReturnTime);
            this.PnlNewOrder.Controls.Add(this.LblPrice);
            this.PnlNewOrder.Controls.Add(this.TxtPrice);
            this.PnlNewOrder.Controls.Add(this.CmbNOBook);
            this.PnlNewOrder.Controls.Add(this.CmbNOCustomer);
            this.PnlNewOrder.Controls.Add(this.LblCustomer);
            this.PnlNewOrder.Location = new System.Drawing.Point(170, 43);
            this.PnlNewOrder.Name = "PnlNewOrder";
            this.PnlNewOrder.Size = new System.Drawing.Size(439, 238);
            this.PnlNewOrder.TabIndex = 4;
            this.PnlNewOrder.Visible = false;
            // 
            // DTPReturnTime
            // 
            this.DTPReturnTime.Location = new System.Drawing.Point(164, 43);
            this.DTPReturnTime.Name = "DTPReturnTime";
            this.DTPReturnTime.Size = new System.Drawing.Size(200, 20);
            this.DTPReturnTime.TabIndex = 12;
            this.DTPReturnTime.ValueChanged += new System.EventHandler(this.DTPReturnTime_ValueChanged);
            // 
            // BtnNOAccept
            // 
            this.BtnNOAccept.BackColor = System.Drawing.Color.Maroon;
            this.BtnNOAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNOAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnNOAccept.Location = new System.Drawing.Point(164, 172);
            this.BtnNOAccept.Name = "BtnNOAccept";
            this.BtnNOAccept.Size = new System.Drawing.Size(142, 51);
            this.BtnNOAccept.TabIndex = 11;
            this.BtnNOAccept.Text = "Accept";
            this.BtnNOAccept.UseVisualStyleBackColor = false;
            this.BtnNOAccept.Click += new System.EventHandler(this.BtnNOAccept_Click);
            // 
            // LblBook
            // 
            this.LblBook.BackColor = System.Drawing.Color.White;
            this.LblBook.Location = new System.Drawing.Point(39, 84);
            this.LblBook.Name = "LblBook";
            this.LblBook.Size = new System.Drawing.Size(74, 25);
            this.LblBook.TabIndex = 10;
            this.LblBook.Text = "Book";
            this.LblBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblReturnTime
            // 
            this.LblReturnTime.BackColor = System.Drawing.Color.White;
            this.LblReturnTime.Location = new System.Drawing.Point(199, 15);
            this.LblReturnTime.Name = "LblReturnTime";
            this.LblReturnTime.Size = new System.Drawing.Size(74, 25);
            this.LblReturnTime.TabIndex = 9;
            this.LblReturnTime.Text = "Return Time";
            this.LblReturnTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPrice
            // 
            this.LblPrice.BackColor = System.Drawing.Color.White;
            this.LblPrice.Location = new System.Drawing.Point(208, 86);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(74, 25);
            this.LblPrice.TabIndex = 8;
            this.LblPrice.Text = "Price";
            this.LblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(185, 114);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.ReadOnly = true;
            this.TxtPrice.Size = new System.Drawing.Size(121, 20);
            this.TxtPrice.TabIndex = 7;
            // 
            // CmbNOBook
            // 
            this.CmbNOBook.FormattingEnabled = true;
            this.CmbNOBook.Location = new System.Drawing.Point(16, 113);
            this.CmbNOBook.Name = "CmbNOBook";
            this.CmbNOBook.Size = new System.Drawing.Size(121, 21);
            this.CmbNOBook.TabIndex = 5;
            // 
            // CmbNOCustomer
            // 
            this.CmbNOCustomer.FormattingEnabled = true;
            this.CmbNOCustomer.Location = new System.Drawing.Point(16, 43);
            this.CmbNOCustomer.Name = "CmbNOCustomer";
            this.CmbNOCustomer.Size = new System.Drawing.Size(121, 21);
            this.CmbNOCustomer.TabIndex = 4;
            // 
            // LblCustomer
            // 
            this.LblCustomer.BackColor = System.Drawing.Color.White;
            this.LblCustomer.Location = new System.Drawing.Point(41, 15);
            this.LblCustomer.Name = "LblCustomer";
            this.LblCustomer.Size = new System.Drawing.Size(74, 25);
            this.LblCustomer.TabIndex = 0;
            this.LblCustomer.Text = "Customer";
            this.LblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCustomers
            // 
            this.BtnCustomers.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCustomers.Location = new System.Drawing.Point(12, 109);
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.Size = new System.Drawing.Size(139, 47);
            this.BtnCustomers.TabIndex = 5;
            this.BtnCustomers.Text = "Customers";
            this.BtnCustomers.UseVisualStyleBackColor = false;
            this.BtnCustomers.Click += new System.EventHandler(this.BtnNewCustomer_Click);
            // 
            // BtnBooks
            // 
            this.BtnBooks.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnBooks.Location = new System.Drawing.Point(12, 178);
            this.BtnBooks.Name = "BtnBooks";
            this.BtnBooks.Size = new System.Drawing.Size(139, 47);
            this.BtnBooks.TabIndex = 6;
            this.BtnBooks.Text = "Books";
            this.BtnBooks.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::library_project.Properties.Resources.library;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.BtnBooks);
            this.Controls.Add(this.BtnCustomers);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.BtnNewOrder);
            this.Controls.Add(this.PnlNewOrder);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.PnlNewOrder.ResumeLayout(false);
            this.PnlNewOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNewOrder;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Panel PnlNewOrder;
        private System.Windows.Forms.Label LblCustomer;
        private System.Windows.Forms.ComboBox CmbNOBook;
        private System.Windows.Forms.ComboBox CmbNOCustomer;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Button BtnNOAccept;
        private System.Windows.Forms.Label LblBook;
        private System.Windows.Forms.Label LblReturnTime;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Button BtnCustomers;
        private System.Windows.Forms.DateTimePicker DTPReturnTime;
        private System.Windows.Forms.Button BtnBooks;
    }
}