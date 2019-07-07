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
    public partial class Customer : Form
    {

        private readonly LibraryContext _context;

        private library_project.Models.Customer SelectedCustomer;


        public Customer()
        {
            InitializeComponent();

            _context = new LibraryContext();

            FillCustomerList();
        }

        //fill customers list func
        private void FillCustomerList()
        {
            DgvCustomers.Rows.Clear();

            foreach (var customer in _context.Customers.ToList())
            {
                DgvCustomers.Rows.Add(customer.Id,
                                      customer.Name,
                                      customer.Surname,
                                      customer.PhoneNumber,
                                      customer.Birthday,
                                      customer.CreateAt);
            }
        }


        //reset customers list
        private void ResetCustomersList()
        {
            DgvCustomers.Rows.Clear();
        }

        //reset new customer form
        private void ResetNewCustomerForm()
        {
            TxtNCName.Text = string.Empty;
            TxtNCSurname.Text = string.Empty;
            TxtNCPhoneNo.Text = string.Empty;
            DTPBirthday.Value = DateTime.Now;

        }

        //customers form close event
        private void Customer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            
        }


        //create new customer event
        private void BtnNewCustomer_Click(object sender, EventArgs e)
        {
            PnlAddNC.Visible = true;
            TxtNCName.Text = string.Empty;
            TxtNCPhoneNo.Text = string.Empty;
            TxtNCSurname.Text = string.Empty;
            DTPBirthday.Value = DateTime.Now;
        }

        //add new customer func
        private void BtnAddNC_Click(object sender, EventArgs e)
        {
            var customer = new library_project.Models.Customer();

            customer.Name = TxtNCName.Text;
            customer.Surname = TxtNCSurname.Text;
            customer.PhoneNumber = TxtNCPhoneNo.Text;
            customer.Birthday = DTPBirthday.Value;
            customer.CreateAt = DateTime.Now;

            _context.Customers.Add(customer);
            _context.SaveChanges();

            PnlAddNC.Hide();
            ResetCustomersList();
            FillCustomerList();
            ResetNewCustomerForm();
            MessageBox.Show("New Customer Created Successfully!");


        }

        //new customer close event
        private void BtnNCClose_Click(object sender, EventArgs e)
        {
            PnlAddNC.Visible = false;
        }

        //delete an existing customer func
        private void BtnDeleteCustomer_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure?", "Delete?", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                _context.Customers.Remove(SelectedCustomer);
                _context.SaveChanges();

                ResetCustomersList();
                FillCustomerList();

                MessageBox.Show("Successfully deleted!");
            }

        }

        //select an existing customer func
        private void DgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnAddNC.Enabled = false;
            BtnDeleteCustomer.Enabled = true;

            int Id = Convert.ToInt32(DgvCustomers.Rows[e.RowIndex].Cells[0].Value.ToString());
            SelectedCustomer = _context.Customers.Find(Id);
        }

        private void DgvCustomers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            

            int Id = Convert.ToInt32(DgvCustomers.Rows[e.RowIndex].Cells[0].Value.ToString());
            SelectedCustomer = _context.Customers.Find(Id);
        }

        //update an existing customer event
        private void BtnUpdateCustomer_Click(object sender, EventArgs e)
        {
            

                TxtNCName.Text = SelectedCustomer.Name;
                TxtNCSurname.Text = SelectedCustomer.Surname;
                TxtNCPhoneNo.Text = SelectedCustomer.PhoneNumber;
                DTPBirthday.Value = SelectedCustomer.Birthday;

                PnlAddNC.Visible = true;
                BtnAddNC.Visible = false;
                BtnCustomerUpd.Visible = true;
            
            
        }

        //update an existing customer func
        private void BtnCustomerUpd_Click(object sender, EventArgs e)
        {
            

            SelectedCustomer.Name = TxtNCName.Text;
            SelectedCustomer.Surname = TxtNCSurname.Text;
            SelectedCustomer.PhoneNumber = TxtNCPhoneNo.Text;
            SelectedCustomer.Birthday = DTPBirthday.Value;

            _context.SaveChanges();

            PnlAddNC.Visible = false;
            ResetCustomersList();
            FillCustomerList();
            ResetNewCustomerForm();

            MessageBox.Show("Information successfully updated!");
        }

        //customer searching func
        private void SearchCustomer()
        {
            DgvCustomers.Rows.Clear();
            List<library_project.Models.Customer> customers = _context.Customers.Where(c => c.Name.Contains(TxtSearchCustomer.Text)
                                                                                    || c.Surname.Contains(TxtSearchCustomer.Text)).ToList();
            foreach (var item in customers)
            {
                DgvCustomers.Rows.Add(item.Id,
                                      item.Name,
                                      item.Surname,
                                      item.PhoneNumber,
                                      item.Birthday,
                                      item.CreateAt);
            }
        }

        //customer search event
        private void TxtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            SearchCustomer();
        }
    }
}
