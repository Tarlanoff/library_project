namespace library_project.Forms
{
    partial class Admin
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
            this.BtnAdminUpd = new System.Windows.Forms.Button();
            this.TxtNANickname = new System.Windows.Forms.TextBox();
            this.LblNANickname = new System.Windows.Forms.Label();
            this.BtnNBClose = new System.Windows.Forms.Button();
            this.BtnAddNewAdmin = new System.Windows.Forms.Button();
            this.TxtNASurname = new System.Windows.Forms.TextBox();
            this.LblNASurname = new System.Windows.Forms.Label();
            this.LblAdmins = new System.Windows.Forms.Label();
            this.DgvAdmins = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtNAName = new System.Windows.Forms.TextBox();
            this.LblNAName = new System.Windows.Forms.Label();
            this.BtnUpdateAdmin = new System.Windows.Forms.Button();
            this.BtnDeleteAdmin = new System.Windows.Forms.Button();
            this.PnlNewAdmin = new System.Windows.Forms.Panel();
            this.TxtNAPassword = new System.Windows.Forms.TextBox();
            this.LblNAPassword = new System.Windows.Forms.Label();
            this.BtnNewAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAdmins)).BeginInit();
            this.PnlNewAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAdminUpd
            // 
            this.BtnAdminUpd.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnAdminUpd.Location = new System.Drawing.Point(216, 288);
            this.BtnAdminUpd.Name = "BtnAdminUpd";
            this.BtnAdminUpd.Size = new System.Drawing.Size(126, 55);
            this.BtnAdminUpd.TabIndex = 11;
            this.BtnAdminUpd.Text = "Update Admin Information";
            this.BtnAdminUpd.UseVisualStyleBackColor = false;
            this.BtnAdminUpd.Visible = false;
            this.BtnAdminUpd.Click += new System.EventHandler(this.BtnAdminUpd_Click);
            // 
            // TxtNANickname
            // 
            this.TxtNANickname.Location = new System.Drawing.Point(216, 168);
            this.TxtNANickname.Name = "TxtNANickname";
            this.TxtNANickname.Size = new System.Drawing.Size(126, 20);
            this.TxtNANickname.TabIndex = 13;
            // 
            // LblNANickname
            // 
            this.LblNANickname.AutoSize = true;
            this.LblNANickname.Location = new System.Drawing.Point(217, 136);
            this.LblNANickname.Name = "LblNANickname";
            this.LblNANickname.Size = new System.Drawing.Size(55, 13);
            this.LblNANickname.TabIndex = 12;
            this.LblNANickname.Text = "Nickname";
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
            this.BtnNBClose.Click += new System.EventHandler(this.BtnNBClose_Click);
            // 
            // BtnAddNewAdmin
            // 
            this.BtnAddNewAdmin.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnAddNewAdmin.Location = new System.Drawing.Point(216, 288);
            this.BtnAddNewAdmin.Name = "BtnAddNewAdmin";
            this.BtnAddNewAdmin.Size = new System.Drawing.Size(126, 55);
            this.BtnAddNewAdmin.TabIndex = 8;
            this.BtnAddNewAdmin.Text = "Create New Admin";
            this.BtnAddNewAdmin.UseVisualStyleBackColor = false;
            this.BtnAddNewAdmin.Click += new System.EventHandler(this.BtnAddNewAdmin_Click);
            // 
            // TxtNASurname
            // 
            this.TxtNASurname.Location = new System.Drawing.Point(216, 101);
            this.TxtNASurname.Name = "TxtNASurname";
            this.TxtNASurname.Size = new System.Drawing.Size(126, 20);
            this.TxtNASurname.TabIndex = 3;
            // 
            // LblNASurname
            // 
            this.LblNASurname.AutoSize = true;
            this.LblNASurname.Location = new System.Drawing.Point(213, 75);
            this.LblNASurname.Name = "LblNASurname";
            this.LblNASurname.Size = new System.Drawing.Size(49, 13);
            this.LblNASurname.TabIndex = 2;
            this.LblNASurname.Text = "Surname";
            // 
            // LblAdmins
            // 
            this.LblAdmins.AutoSize = true;
            this.LblAdmins.BackColor = System.Drawing.Color.Transparent;
            this.LblAdmins.Font = new System.Drawing.Font("Papyrus", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdmins.ForeColor = System.Drawing.Color.OrangeRed;
            this.LblAdmins.Location = new System.Drawing.Point(323, 5);
            this.LblAdmins.Name = "LblAdmins";
            this.LblAdmins.Size = new System.Drawing.Size(266, 55);
            this.LblAdmins.TabIndex = 14;
            this.LblAdmins.Text = "Administrators";
            // 
            // DgvAdmins
            // 
            this.DgvAdmins.AllowUserToAddRows = false;
            this.DgvAdmins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAdmins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DgvAdmins.Location = new System.Drawing.Point(223, 86);
            this.DgvAdmins.Name = "DgvAdmins";
            this.DgvAdmins.Size = new System.Drawing.Size(544, 193);
            this.DgvAdmins.TabIndex = 13;
            this.DgvAdmins.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvAdmins_RowHeaderMouseClick);
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
            this.Column4.HeaderText = "Nickname";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Password";
            this.Column5.Name = "Column5";
            // 
            // TxtNAName
            // 
            this.TxtNAName.Location = new System.Drawing.Point(216, 40);
            this.TxtNAName.Name = "TxtNAName";
            this.TxtNAName.Size = new System.Drawing.Size(126, 20);
            this.TxtNAName.TabIndex = 1;
            // 
            // LblNAName
            // 
            this.LblNAName.AutoSize = true;
            this.LblNAName.Location = new System.Drawing.Point(213, 14);
            this.LblNAName.Name = "LblNAName";
            this.LblNAName.Size = new System.Drawing.Size(35, 13);
            this.LblNAName.TabIndex = 0;
            this.LblNAName.Text = "Name";
            // 
            // BtnUpdateAdmin
            // 
            this.BtnUpdateAdmin.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnUpdateAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnUpdateAdmin.Location = new System.Drawing.Point(39, 232);
            this.BtnUpdateAdmin.Name = "BtnUpdateAdmin";
            this.BtnUpdateAdmin.Size = new System.Drawing.Size(159, 59);
            this.BtnUpdateAdmin.TabIndex = 18;
            this.BtnUpdateAdmin.Text = "Update Admin Info";
            this.BtnUpdateAdmin.UseVisualStyleBackColor = false;
            this.BtnUpdateAdmin.Click += new System.EventHandler(this.BtnUpdateAdmin_Click);
            // 
            // BtnDeleteAdmin
            // 
            this.BtnDeleteAdmin.BackColor = System.Drawing.Color.Red;
            this.BtnDeleteAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDeleteAdmin.Location = new System.Drawing.Point(39, 153);
            this.BtnDeleteAdmin.Name = "BtnDeleteAdmin";
            this.BtnDeleteAdmin.Size = new System.Drawing.Size(159, 59);
            this.BtnDeleteAdmin.TabIndex = 17;
            this.BtnDeleteAdmin.Text = "Delete Admin";
            this.BtnDeleteAdmin.UseVisualStyleBackColor = false;
            this.BtnDeleteAdmin.Click += new System.EventHandler(this.BtnDeleteAdmin_Click);
            // 
            // PnlNewAdmin
            // 
            this.PnlNewAdmin.BackColor = System.Drawing.Color.Orange;
            this.PnlNewAdmin.Controls.Add(this.TxtNAPassword);
            this.PnlNewAdmin.Controls.Add(this.LblNAPassword);
            this.PnlNewAdmin.Controls.Add(this.TxtNANickname);
            this.PnlNewAdmin.Controls.Add(this.LblNANickname);
            this.PnlNewAdmin.Controls.Add(this.BtnAdminUpd);
            this.PnlNewAdmin.Controls.Add(this.BtnNBClose);
            this.PnlNewAdmin.Controls.Add(this.BtnAddNewAdmin);
            this.PnlNewAdmin.Controls.Add(this.TxtNASurname);
            this.PnlNewAdmin.Controls.Add(this.LblNASurname);
            this.PnlNewAdmin.Controls.Add(this.TxtNAName);
            this.PnlNewAdmin.Controls.Add(this.LblNAName);
            this.PnlNewAdmin.Location = new System.Drawing.Point(223, 86);
            this.PnlNewAdmin.Name = "PnlNewAdmin";
            this.PnlNewAdmin.Size = new System.Drawing.Size(544, 359);
            this.PnlNewAdmin.TabIndex = 16;
            this.PnlNewAdmin.Visible = false;
            // 
            // TxtNAPassword
            // 
            this.TxtNAPassword.Location = new System.Drawing.Point(216, 237);
            this.TxtNAPassword.Name = "TxtNAPassword";
            this.TxtNAPassword.Size = new System.Drawing.Size(126, 20);
            this.TxtNAPassword.TabIndex = 15;
            // 
            // LblNAPassword
            // 
            this.LblNAPassword.AutoSize = true;
            this.LblNAPassword.Location = new System.Drawing.Point(217, 205);
            this.LblNAPassword.Name = "LblNAPassword";
            this.LblNAPassword.Size = new System.Drawing.Size(53, 13);
            this.LblNAPassword.TabIndex = 14;
            this.LblNAPassword.Text = "Password";
            // 
            // BtnNewAdmin
            // 
            this.BtnNewAdmin.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnNewAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnNewAdmin.Location = new System.Drawing.Point(39, 86);
            this.BtnNewAdmin.Name = "BtnNewAdmin";
            this.BtnNewAdmin.Size = new System.Drawing.Size(159, 55);
            this.BtnNewAdmin.TabIndex = 15;
            this.BtnNewAdmin.Text = "New Admin";
            this.BtnNewAdmin.UseVisualStyleBackColor = false;
            this.BtnNewAdmin.Click += new System.EventHandler(this.BtnNewAdmin_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblAdmins);
            this.Controls.Add(this.DgvAdmins);
            this.Controls.Add(this.BtnUpdateAdmin);
            this.Controls.Add(this.BtnDeleteAdmin);
            this.Controls.Add(this.PnlNewAdmin);
            this.Controls.Add(this.BtnNewAdmin);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.DgvAdmins)).EndInit();
            this.PnlNewAdmin.ResumeLayout(false);
            this.PnlNewAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAdminUpd;
        private System.Windows.Forms.TextBox TxtNANickname;
        private System.Windows.Forms.Label LblNANickname;
        private System.Windows.Forms.Button BtnNBClose;
        private System.Windows.Forms.Button BtnAddNewAdmin;
        private System.Windows.Forms.TextBox TxtNASurname;
        private System.Windows.Forms.Label LblNASurname;
        private System.Windows.Forms.Label LblAdmins;
        private System.Windows.Forms.DataGridView DgvAdmins;
        private System.Windows.Forms.TextBox TxtNAName;
        private System.Windows.Forms.Label LblNAName;
        private System.Windows.Forms.Button BtnUpdateAdmin;
        private System.Windows.Forms.Button BtnDeleteAdmin;
        private System.Windows.Forms.Panel PnlNewAdmin;
        private System.Windows.Forms.Button BtnNewAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox TxtNAPassword;
        private System.Windows.Forms.Label LblNAPassword;
    }
}