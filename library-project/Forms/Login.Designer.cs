namespace library_project.Forms
{
    partial class Login
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
            this.LblNickname = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtNickname = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNickname
            // 
            this.LblNickname.BackColor = System.Drawing.Color.Transparent;
            this.LblNickname.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNickname.ForeColor = System.Drawing.Color.Indigo;
            this.LblNickname.Location = new System.Drawing.Point(217, 157);
            this.LblNickname.Name = "LblNickname";
            this.LblNickname.Size = new System.Drawing.Size(313, 56);
            this.LblNickname.TabIndex = 0;
            this.LblNickname.Text = "Nickname";
            this.LblNickname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPassword
            // 
            this.LblPassword.BackColor = System.Drawing.Color.Transparent;
            this.LblPassword.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.ForeColor = System.Drawing.Color.Indigo;
            this.LblPassword.Location = new System.Drawing.Point(214, 255);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(316, 56);
            this.LblPassword.TabIndex = 1;
            this.LblPassword.Text = "Password";
            this.LblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtNickname
            // 
            this.TxtNickname.Location = new System.Drawing.Point(273, 216);
            this.TxtNickname.Name = "TxtNickname";
            this.TxtNickname.Size = new System.Drawing.Size(201, 20);
            this.TxtNickname.TabIndex = 2;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(273, 314);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '■';
            this.TxtPassword.Size = new System.Drawing.Size(201, 20);
            this.TxtPassword.TabIndex = 3;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Indigo;
            this.BtnLogin.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(273, 338);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(201, 87);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::library_project.Properties.Resources.library_login;
            this.ClientSize = new System.Drawing.Size(788, 437);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtNickname);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblNickname);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNickname;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtNickname;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnLogin;
    }
}