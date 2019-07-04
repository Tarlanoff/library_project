namespace library_project.Forms
{
    partial class Customer
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
            this.DgvCustomers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblCustomers = new System.Windows.Forms.Label();
            this.BtnNewCustomer = new System.Windows.Forms.Button();
            this.PnlAddNC = new System.Windows.Forms.Panel();
            this.BtnNCClose = new System.Windows.Forms.Button();
            this.DTPBirthday = new System.Windows.Forms.DateTimePicker();
            this.BtnAddNC = new System.Windows.Forms.Button();
            this.LblNCBirthday = new System.Windows.Forms.Label();
            this.TxtNCPhoneNo = new System.Windows.Forms.TextBox();
            this.LblNCPhoneNo = new System.Windows.Forms.Label();
            this.TxtNCSurname = new System.Windows.Forms.TextBox();
            this.LblNCSurname = new System.Windows.Forms.Label();
            this.TxtNCName = new System.Windows.Forms.TextBox();
            this.LblNCName = new System.Windows.Forms.Label();
            this.BtnDeleteCustomer = new System.Windows.Forms.Button();
            this.BtnUpdateCustomer = new System.Windows.Forms.Button();
            this.BtnCustomerUpd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomers)).BeginInit();
            this.PnlAddNC.SuspendLayout();
            this.SuspendLayout();
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
            this.DgvCustomers.Location = new System.Drawing.Point(204, 87);
            this.DgvCustomers.Name = "DgvCustomers";
            this.DgvCustomers.Size = new System.Drawing.Size(544, 193);
            this.DgvCustomers.TabIndex = 0;
            this.DgvCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCustomers_CellContentClick);
            this.DgvCustomers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvCustomers_RowHeaderMouseClick);
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
            this.Column3.HeaderText = "Surname";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Phone Number";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Birthday";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "CreatedAt";
            this.Column6.Name = "Column6";
            // 
            // LblCustomers
            // 
            this.LblCustomers.AutoSize = true;
            this.LblCustomers.BackColor = System.Drawing.Color.Transparent;
            this.LblCustomers.Font = new System.Drawing.Font("Papyrus", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCustomers.ForeColor = System.Drawing.Color.OrangeRed;
            this.LblCustomers.Location = new System.Drawing.Point(312, 6);
            this.LblCustomers.Name = "LblCustomers";
            this.LblCustomers.Size = new System.Drawing.Size(202, 55);
            this.LblCustomers.TabIndex = 1;
            this.LblCustomers.Text = "Customers";
            // 
            // BtnNewCustomer
            // 
            this.BtnNewCustomer.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnNewCustomer.Location = new System.Drawing.Point(28, 87);
            this.BtnNewCustomer.Name = "BtnNewCustomer";
            this.BtnNewCustomer.Size = new System.Drawing.Size(159, 55);
            this.BtnNewCustomer.TabIndex = 2;
            this.BtnNewCustomer.Text = "New Customer";
            this.BtnNewCustomer.UseVisualStyleBackColor = false;
            this.BtnNewCustomer.Click += new System.EventHandler(this.BtnNewCustomer_Click);
            // 
            // PnlAddNC
            // 
            this.PnlAddNC.BackColor = System.Drawing.Color.Orange;
            this.PnlAddNC.Controls.Add(this.BtnCustomerUpd);
            this.PnlAddNC.Controls.Add(this.BtnNCClose);
            this.PnlAddNC.Controls.Add(this.DTPBirthday);
            this.PnlAddNC.Controls.Add(this.BtnAddNC);
            this.PnlAddNC.Controls.Add(this.LblNCBirthday);
            this.PnlAddNC.Controls.Add(this.TxtNCPhoneNo);
            this.PnlAddNC.Controls.Add(this.LblNCPhoneNo);
            this.PnlAddNC.Controls.Add(this.TxtNCSurname);
            this.PnlAddNC.Controls.Add(this.LblNCSurname);
            this.PnlAddNC.Controls.Add(this.TxtNCName);
            this.PnlAddNC.Controls.Add(this.LblNCName);
            this.PnlAddNC.Location = new System.Drawing.Point(204, 64);
            this.PnlAddNC.Name = "PnlAddNC";
            this.PnlAddNC.Size = new System.Drawing.Size(544, 359);
            this.PnlAddNC.TabIndex = 3;
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
            this.BtnNCClose.Click += new System.EventHandler(this.BtnNCClose_Click);
            // 
            // DTPBirthday
            // 
            this.DTPBirthday.Location = new System.Drawing.Point(188, 244);
            this.DTPBirthday.Name = "DTPBirthday";
            this.DTPBirthday.Size = new System.Drawing.Size(175, 20);
            this.DTPBirthday.TabIndex = 9;
            // 
            // BtnAddNC
            // 
            this.BtnAddNC.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnAddNC.Location = new System.Drawing.Point(216, 284);
            this.BtnAddNC.Name = "BtnAddNC";
            this.BtnAddNC.Size = new System.Drawing.Size(126, 55);
            this.BtnAddNC.TabIndex = 8;
            this.BtnAddNC.Text = "Create New Customer";
            this.BtnAddNC.UseVisualStyleBackColor = false;
            this.BtnAddNC.Click += new System.EventHandler(this.BtnAddNC_Click);
            // 
            // LblNCBirthday
            // 
            this.LblNCBirthday.AutoSize = true;
            this.LblNCBirthday.Location = new System.Drawing.Point(213, 216);
            this.LblNCBirthday.Name = "LblNCBirthday";
            this.LblNCBirthday.Size = new System.Drawing.Size(45, 13);
            this.LblNCBirthday.TabIndex = 6;
            this.LblNCBirthday.Text = "Birthday";
            // 
            // TxtNCPhoneNo
            // 
            this.TxtNCPhoneNo.Location = new System.Drawing.Point(216, 169);
            this.TxtNCPhoneNo.Name = "TxtNCPhoneNo";
            this.TxtNCPhoneNo.Size = new System.Drawing.Size(126, 20);
            this.TxtNCPhoneNo.TabIndex = 5;
            // 
            // LblNCPhoneNo
            // 
            this.LblNCPhoneNo.AutoSize = true;
            this.LblNCPhoneNo.Location = new System.Drawing.Point(213, 143);
            this.LblNCPhoneNo.Name = "LblNCPhoneNo";
            this.LblNCPhoneNo.Size = new System.Drawing.Size(78, 13);
            this.LblNCPhoneNo.TabIndex = 4;
            this.LblNCPhoneNo.Text = "Phone Number";
            // 
            // TxtNCSurname
            // 
            this.TxtNCSurname.Location = new System.Drawing.Point(216, 101);
            this.TxtNCSurname.Name = "TxtNCSurname";
            this.TxtNCSurname.Size = new System.Drawing.Size(126, 20);
            this.TxtNCSurname.TabIndex = 3;
            // 
            // LblNCSurname
            // 
            this.LblNCSurname.AutoSize = true;
            this.LblNCSurname.Location = new System.Drawing.Point(213, 75);
            this.LblNCSurname.Name = "LblNCSurname";
            this.LblNCSurname.Size = new System.Drawing.Size(49, 13);
            this.LblNCSurname.TabIndex = 2;
            this.LblNCSurname.Text = "Surname";
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
            // BtnDeleteCustomer
            // 
            this.BtnDeleteCustomer.BackColor = System.Drawing.Color.Red;
            this.BtnDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDeleteCustomer.Location = new System.Drawing.Point(28, 154);
            this.BtnDeleteCustomer.Name = "BtnDeleteCustomer";
            this.BtnDeleteCustomer.Size = new System.Drawing.Size(159, 59);
            this.BtnDeleteCustomer.TabIndex = 4;
            this.BtnDeleteCustomer.Text = "Delete Customer";
            this.BtnDeleteCustomer.UseVisualStyleBackColor = false;
            this.BtnDeleteCustomer.Click += new System.EventHandler(this.BtnDeleteCustomer_Click);
            // 
            // BtnUpdateCustomer
            // 
            this.BtnUpdateCustomer.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnUpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnUpdateCustomer.Location = new System.Drawing.Point(28, 233);
            this.BtnUpdateCustomer.Name = "BtnUpdateCustomer";
            this.BtnUpdateCustomer.Size = new System.Drawing.Size(159, 59);
            this.BtnUpdateCustomer.TabIndex = 5;
            this.BtnUpdateCustomer.Text = "Update Customer Info";
            this.BtnUpdateCustomer.UseVisualStyleBackColor = false;
            this.BtnUpdateCustomer.Click += new System.EventHandler(this.BtnUpdateCustomer_Click);
            // 
            // BtnCustomerUpd
            // 
            this.BtnCustomerUpd.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnCustomerUpd.Location = new System.Drawing.Point(216, 284);
            this.BtnCustomerUpd.Name = "BtnCustomerUpd";
            this.BtnCustomerUpd.Size = new System.Drawing.Size(126, 55);
            this.BtnCustomerUpd.TabIndex = 11;
            this.BtnCustomerUpd.Text = "Update Customer Information";
            this.BtnCustomerUpd.UseVisualStyleBackColor = false;
            this.BtnCustomerUpd.Visible = false;
            this.BtnCustomerUpd.Click += new System.EventHandler(this.BtnCustomerUpd_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnUpdateCustomer);
            this.Controls.Add(this.BtnDeleteCustomer);
            this.Controls.Add(this.PnlAddNC);
            this.Controls.Add(this.BtnNewCustomer);
            this.Controls.Add(this.LblCustomers);
            this.Controls.Add(this.DgvCustomers);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Customer_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomers)).EndInit();
            this.PnlAddNC.ResumeLayout(false);
            this.PnlAddNC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCustomers;
        private System.Windows.Forms.Label LblCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button BtnNewCustomer;
        private System.Windows.Forms.Panel PnlAddNC;
        private System.Windows.Forms.TextBox TxtNCName;
        private System.Windows.Forms.Label LblNCName;
        private System.Windows.Forms.Button BtnAddNC;
        private System.Windows.Forms.Label LblNCBirthday;
        private System.Windows.Forms.TextBox TxtNCPhoneNo;
        private System.Windows.Forms.Label LblNCPhoneNo;
        private System.Windows.Forms.TextBox TxtNCSurname;
        private System.Windows.Forms.Label LblNCSurname;
        private System.Windows.Forms.DateTimePicker DTPBirthday;
        private System.Windows.Forms.Button BtnNCClose;
        private System.Windows.Forms.Button BtnDeleteCustomer;
        private System.Windows.Forms.Button BtnUpdateCustomer;
        private System.Windows.Forms.Button BtnCustomerUpd;
    }
}