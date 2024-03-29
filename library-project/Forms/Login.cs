﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using library_project.DAL;
using library_project.Models;


namespace library_project.Forms
{
    public partial class Login : Form
    {

        private readonly LibraryContext _context;
        public Login()
        {

            InitializeComponent();

            _context = new LibraryContext();
        }

        //logging in func and val
        private void BtnLogin_Click(object sender, EventArgs e)
        {

            if (!_context.Admins.Any(a => a.Nickname == TxtNickname.Text))
            {
                MessageBox.Show("Nickname və ya Password düzgün daxil edilməyib!");
                return;
            }

            if (_context.Admins.Any(a => a.Nickname == TxtNickname.Text && a.Password == TxtPassword.Text))
            {
                Dashboard dashboard = new Dashboard();
                this.Hide();
                dashboard.Show();
            }

            else
            {
                MessageBox.Show("Nickname və ya Password düzgün daxil edilməyib!");
                return;
            }
        }

        //closing event
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
