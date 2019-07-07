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
            this.BtnCustomers = new System.Windows.Forms.Button();
            this.BtnBooks = new System.Windows.Forms.Button();
            this.BtnAdmins = new System.Windows.Forms.Button();
            this.PnlNewOrder = new System.Windows.Forms.Panel();
            this.BtnOrderClose = new System.Windows.Forms.Button();
            this.BtnNOAccept = new System.Windows.Forms.Button();
            this.LblNewOrder = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.DTPNOReturnTime = new System.Windows.Forms.DateTimePicker();
            this.CmbNOBook = new System.Windows.Forms.ComboBox();
            this.CmbNOCustomer = new System.Windows.Forms.ComboBox();
            this.LblNOPrice = new System.Windows.Forms.Label();
            this.LblNOReturnTime = new System.Windows.Forms.Label();
            this.LblNOBook = new System.Windows.Forms.Label();
            this.LblNOCustomer = new System.Windows.Forms.Label();
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
            this.BtnBooks.Click += new System.EventHandler(this.BtnBooks_Click);
            // 
            // BtnAdmins
            // 
            this.BtnAdmins.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnAdmins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAdmins.Location = new System.Drawing.Point(12, 244);
            this.BtnAdmins.Name = "BtnAdmins";
            this.BtnAdmins.Size = new System.Drawing.Size(139, 47);
            this.BtnAdmins.TabIndex = 7;
            this.BtnAdmins.Text = "Administrators";
            this.BtnAdmins.UseVisualStyleBackColor = false;
            this.BtnAdmins.Click += new System.EventHandler(this.BtnAdmins_Click);
            // 
            // PnlNewOrder
            // 
            this.PnlNewOrder.Controls.Add(this.BtnOrderClose);
            this.PnlNewOrder.Controls.Add(this.BtnNOAccept);
            this.PnlNewOrder.Controls.Add(this.LblNewOrder);
            this.PnlNewOrder.Controls.Add(this.TxtPrice);
            this.PnlNewOrder.Controls.Add(this.DTPNOReturnTime);
            this.PnlNewOrder.Controls.Add(this.CmbNOBook);
            this.PnlNewOrder.Controls.Add(this.CmbNOCustomer);
            this.PnlNewOrder.Controls.Add(this.LblNOPrice);
            this.PnlNewOrder.Controls.Add(this.LblNOReturnTime);
            this.PnlNewOrder.Controls.Add(this.LblNOBook);
            this.PnlNewOrder.Controls.Add(this.LblNOCustomer);
            this.PnlNewOrder.Location = new System.Drawing.Point(182, 43);
            this.PnlNewOrder.Name = "PnlNewOrder";
            this.PnlNewOrder.Size = new System.Drawing.Size(627, 318);
            this.PnlNewOrder.TabIndex = 8;
            this.PnlNewOrder.Visible = false;
            // 
            // BtnOrderClose
            // 
            this.BtnOrderClose.BackColor = System.Drawing.Color.Red;
            this.BtnOrderClose.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrderClose.ForeColor = System.Drawing.Color.Black;
            this.BtnOrderClose.Location = new System.Drawing.Point(535, 3);
            this.BtnOrderClose.Name = "BtnOrderClose";
            this.BtnOrderClose.Size = new System.Drawing.Size(89, 31);
            this.BtnOrderClose.TabIndex = 10;
            this.BtnOrderClose.Text = "Close";
            this.BtnOrderClose.UseVisualStyleBackColor = false;
            this.BtnOrderClose.Click += new System.EventHandler(this.BtnOrderClose_Click);
            // 
            // BtnNOAccept
            // 
            this.BtnNOAccept.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnNOAccept.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNOAccept.ForeColor = System.Drawing.Color.Black;
            this.BtnNOAccept.Location = new System.Drawing.Point(475, 188);
            this.BtnNOAccept.Name = "BtnNOAccept";
            this.BtnNOAccept.Size = new System.Drawing.Size(134, 74);
            this.BtnNOAccept.TabIndex = 9;
            this.BtnNOAccept.Text = "Accept";
            this.BtnNOAccept.UseVisualStyleBackColor = false;
            this.BtnNOAccept.Click += new System.EventHandler(this.BtnNOAccept_Click);
            // 
            // LblNewOrder
            // 
            this.LblNewOrder.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewOrder.ForeColor = System.Drawing.Color.OrangeRed;
            this.LblNewOrder.Location = new System.Drawing.Point(147, 20);
            this.LblNewOrder.Name = "LblNewOrder";
            this.LblNewOrder.Size = new System.Drawing.Size(339, 48);
            this.LblNewOrder.TabIndex = 8;
            this.LblNewOrder.Text = "New Order";
            this.LblNewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(296, 287);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.ReadOnly = true;
            this.TxtPrice.Size = new System.Drawing.Size(138, 20);
            this.TxtPrice.TabIndex = 7;
            this.TxtPrice.Text = "0";
            // 
            // DTPNOReturnTime
            // 
            this.DTPNOReturnTime.Location = new System.Drawing.Point(296, 162);
            this.DTPNOReturnTime.Name = "DTPNOReturnTime";
            this.DTPNOReturnTime.Size = new System.Drawing.Size(138, 20);
            this.DTPNOReturnTime.TabIndex = 6;
            this.DTPNOReturnTime.ValueChanged += new System.EventHandler(this.DTPNOReturnTime_ValueChanged);
            // 
            // CmbNOBook
            // 
            this.CmbNOBook.FormattingEnabled = true;
            this.CmbNOBook.Location = new System.Drawing.Point(57, 287);
            this.CmbNOBook.Name = "CmbNOBook";
            this.CmbNOBook.Size = new System.Drawing.Size(181, 21);
            this.CmbNOBook.TabIndex = 5;
            this.CmbNOBook.Text = "Select";
            // 
            // CmbNOCustomer
            // 
            this.CmbNOCustomer.FormattingEnabled = true;
            this.CmbNOCustomer.Location = new System.Drawing.Point(57, 162);
            this.CmbNOCustomer.Name = "CmbNOCustomer";
            this.CmbNOCustomer.Size = new System.Drawing.Size(181, 21);
            this.CmbNOCustomer.TabIndex = 4;
            this.CmbNOCustomer.Text = "Select";
            // 
            // LblNOPrice
            // 
            this.LblNOPrice.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNOPrice.ForeColor = System.Drawing.Color.OrangeRed;
            this.LblNOPrice.Location = new System.Drawing.Point(291, 205);
            this.LblNOPrice.Name = "LblNOPrice";
            this.LblNOPrice.Size = new System.Drawing.Size(124, 66);
            this.LblNOPrice.TabIndex = 3;
            this.LblNOPrice.Text = "Price";
            this.LblNOPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblNOReturnTime
            // 
            this.LblNOReturnTime.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNOReturnTime.ForeColor = System.Drawing.Color.OrangeRed;
            this.LblNOReturnTime.Location = new System.Drawing.Point(291, 93);
            this.LblNOReturnTime.Name = "LblNOReturnTime";
            this.LblNOReturnTime.Size = new System.Drawing.Size(124, 66);
            this.LblNOReturnTime.TabIndex = 2;
            this.LblNOReturnTime.Text = "Return Time";
            this.LblNOReturnTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblNOBook
            // 
            this.LblNOBook.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNOBook.ForeColor = System.Drawing.Color.OrangeRed;
            this.LblNOBook.Location = new System.Drawing.Point(52, 205);
            this.LblNOBook.Name = "LblNOBook";
            this.LblNOBook.Size = new System.Drawing.Size(124, 66);
            this.LblNOBook.TabIndex = 1;
            this.LblNOBook.Text = "Book Name";
            this.LblNOBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblNOCustomer
            // 
            this.LblNOCustomer.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNOCustomer.ForeColor = System.Drawing.Color.OrangeRed;
            this.LblNOCustomer.Location = new System.Drawing.Point(52, 93);
            this.LblNOCustomer.Name = "LblNOCustomer";
            this.LblNOCustomer.Size = new System.Drawing.Size(124, 66);
            this.LblNOCustomer.TabIndex = 0;
            this.LblNOCustomer.Text = "Customer Name";
            this.LblNOCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::library_project.Properties.Resources.library;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.PnlNewOrder);
            this.Controls.Add(this.BtnAdmins);
            this.Controls.Add(this.BtnBooks);
            this.Controls.Add(this.BtnCustomers);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.BtnNewOrder);
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
        private System.Windows.Forms.Button BtnCustomers;
        private System.Windows.Forms.Button BtnBooks;
        private System.Windows.Forms.Button BtnAdmins;
        private System.Windows.Forms.Panel PnlNewOrder;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.DateTimePicker DTPNOReturnTime;
        private System.Windows.Forms.ComboBox CmbNOBook;
        private System.Windows.Forms.ComboBox CmbNOCustomer;
        private System.Windows.Forms.Label LblNOPrice;
        private System.Windows.Forms.Label LblNOReturnTime;
        private System.Windows.Forms.Label LblNOBook;
        private System.Windows.Forms.Label LblNOCustomer;
        private System.Windows.Forms.Button BtnNOAccept;
        private System.Windows.Forms.Label LblNewOrder;
        private System.Windows.Forms.Button BtnOrderClose;
    }
}