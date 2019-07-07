using library_project.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_project.Forms
{
    public partial class Admin : Form
    {

        private readonly LibraryContext _context;

        private library_project.Models.Admin SelectedAdmin;

        public Admin()
        {
            InitializeComponent();

            _context = new LibraryContext();

            FillAdminList();
        }

        //fill admin list function
        private void FillAdminList()
        {
            DgvAdmins.Rows.Clear();

            foreach (var admin in _context.Admins.ToList())
            {
                DgvAdmins.Rows.Add(admin.Id,
                                   admin.Name,
                                   admin.Surname,
                                   admin.Nickname,
                                   admin.Password);
            }
        }

        //reset admin list fucktion
        private void ResetAdminList()
        {
            DgvAdmins.Rows.Clear();
        }

        //reset new admin form event
        private void ResetNewAdminForm()
        {
            TxtNAName.Text = string.Empty;
            TxtNASurname.Text = string.Empty;
            TxtNANickname.Text = string.Empty;
            TxtNAPassword.Text = string.Empty;
        }

        //new admin button event
        private void BtnNewAdmin_Click(object sender, EventArgs e)
        {
            DgvAdmins.Visible = false;
            PnlNewAdmin.Visible = true;
            TxtNAName.Text = string.Empty;
            TxtNASurname.Text = string.Empty;
            TxtNANickname.Text = string.Empty;
            TxtNAPassword.Text = string.Empty;
        }

        //new admin creating function
        private void BtnAddNewAdmin_Click(object sender, EventArgs e)
        {
            var admin = new library_project.Models.Admin();

            admin.Name = TxtNAName.Text;
            admin.Surname = TxtNASurname.Text;
            admin.Nickname = TxtNANickname.Text;
            admin.Password = TxtNAPassword.Text;

            _context.Admins.Add(admin);
            _context.SaveChanges();

            PnlNewAdmin.Hide();
            ResetAdminList();
            FillAdminList();
            ResetNewAdminForm();
            DgvAdmins.Visible = true;
            MessageBox.Show("New Admin Created Successfully!");

        }

        //creating new admin close event
        private void BtnNBClose_Click(object sender, EventArgs e)
        {
            PnlNewAdmin.Visible = false;
            DgvAdmins.Visible = true;
        }

        //selection of an existing admin function
        private void DgvAdmins_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Id = Convert.ToInt32(DgvAdmins.Rows[e.RowIndex].Cells[0].Value.ToString());
            SelectedAdmin = _context.Admins.Find(Id);
        }

        //delete an existing admin function
        private void BtnDeleteAdmin_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure?", "Delete?", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                _context.Admins.Remove(SelectedAdmin);
                _context.SaveChanges();

                ResetAdminList();
                FillAdminList();

                MessageBox.Show("Successfully deleted!");
            }
        }

        //update an existing admin func
        private void BtnUpdateAdmin_Click(object sender, EventArgs e)
        {
            PnlNewAdmin.Visible = true;
            BtnAdminUpd.Visible = true;
            BtnAddNewAdmin.Visible = false;
            DgvAdmins.Visible = false;

            TxtNAName.Text = SelectedAdmin.Name;
            TxtNASurname.Text = SelectedAdmin.Surname;
            TxtNANickname.Text = SelectedAdmin.Nickname;
            TxtNAPassword.Text = SelectedAdmin.Password;
        }

        //update an existing admin event
        private void BtnAdminUpd_Click(object sender, EventArgs e)
        {
            SelectedAdmin.Name = TxtNAName.Text;
            SelectedAdmin.Surname = TxtNASurname.Text;
            SelectedAdmin.Nickname = TxtNANickname.Text;
            SelectedAdmin.Password = TxtNAPassword.Text;

            _context.SaveChanges();

            ResetAdminList();
            FillAdminList();
            ResetNewAdminForm();
            PnlNewAdmin.Visible = false;
            DgvAdmins.Visible = true;

            MessageBox.Show("Information successfully updated!");
        }
    }
}
