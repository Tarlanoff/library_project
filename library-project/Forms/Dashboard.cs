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
using library_project.Forms;
using library_project.Models;

namespace library_project.Forms
{
    public partial class Dashboard : Form
    {

        private readonly LibraryContext _context;

        private Book SelectedBook;

        public Dashboard()
        {
            InitializeComponent();

            _context = new LibraryContext();
        }

        private void BtnNewOrder_Click(object sender, EventArgs e)
        {
            PnlNewOrder.Visible = true;

            FillCustomerList();
            FillBookList();
            CalcPriceWithReturnDate();


            TxtPrice.Text = "0";
        }

        private void DTPReturnTime_ValueChanged(object sender, EventArgs e)
        {
            CalcPriceWithReturnDate();
        }


        #region logout, exit function
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            login.Show();
            this.Hide();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        #endregion


        #region fill functions

        private void FillCustomerList()
        {
            foreach (var customer in _context.Customers.ToList())
            {
                CmbNOCustomer.Items.Add(customer.Name + customer.Surname);
            }
        }


        private void FillBookList()
        {
            foreach (var book in _context.Books.ToList())
            {
                CmbNOBook.Items.Add(book.Name);
            }
        }
        #endregion


        #region calculate function
        private void CalcPriceWithReturnDate()
        {
            CmbNOBook.SelectedIndex = 0;
            int id = _context.Books.FirstOrDefault(b => b.Name == CmbNOBook.Text).Id;

            SelectedBook = _context.Books.Find(id);

            if (DTPReturnTime.Value <= DateTime.Now.AddDays(7))
            {
                TxtPrice.Text = SelectedBook.PricePerMonth.ToString();
            }
            if (DTPReturnTime.Value > DateTime.Now.AddDays(7) && DTPReturnTime.Value <= DateTime.Now.AddDays(14))
            {
                TxtPrice.Text = (SelectedBook.PricePerMonth * 2).ToString();
            }
            if (DTPReturnTime.Value>DateTime.Now.AddDays(14) && DTPReturnTime.Value <= DateTime.Now.AddDays(21))
            {
                TxtPrice.Text = (SelectedBook.PricePerMonth * 3).ToString();
            }
            if (DTPReturnTime.Value > DateTime.Now.AddDays(21) && DTPReturnTime.Value <= DateTime.Now.AddDays(28))
            {
                TxtPrice.Text = (SelectedBook.PricePerMonth * 4).ToString();
            }
            if (DTPReturnTime.Value > DateTime.Now.AddMonths(1) && DTPReturnTime.Value <= DateTime.Now.AddMonths(2))
            {
                TxtPrice.Text = (SelectedBook.PricePerMonth * 6).ToString();
            }

        }

        #endregion


        private void ResetOrderForm()
        {
            CmbNOBook.SelectedIndex = 0;
            CmbNOCustomer.Text = string.Empty;
            DTPReturnTime.Value = DateTime.Now;
            TxtPrice.Text = "0";
        }

        private void BtnNOAccept_Click(object sender, EventArgs e)
        {
            ResetOrderForm();
            PnlNewOrder.Visible = false;
            
        }

        private void BtnNewCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
        }

        private void BtnOrderClose_Click(object sender, EventArgs e)
        {
            PnlNewOrder.Visible = false;
        }
    }
}
