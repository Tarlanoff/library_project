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

        private library_project.Models.Book SelectedBook;


        public Dashboard()
        {
            InitializeComponent();

            _context = new LibraryContext();
        }

       


        //logout
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            login.Show();
            this.Hide();
        }

        //app close
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        


        
        //istifadecilerin adi soyadi
        private void FillCustomerList()
        {
            foreach (var customer in _context.Customers.ToList())
            {
                CmbNOCustomer.Items.Add(customer.Name + " " + customer.Surname);
            }
        }

        //kitablarin adi
        private void FillBookList()
        {
            foreach (var book in _context.Books.ToList())
            {
                CmbNOBook.Items.Add(book.Name);
            }
        }


       


        //qiymet hesabati
        private void CalcPriceWithReturnDate()
        {
            
            int id = _context.Books.FirstOrDefault(b => b.Name == CmbNOBook.Text).Id;

            SelectedBook = _context.Books.Find(id);

            if (DTPNOReturnTime.Value <= DateTime.Now.AddDays(7))
            {
                TxtPrice.Text = SelectedBook.PricePerMonth.ToString();
            }
            if (DTPNOReturnTime.Value > DateTime.Now.AddDays(7) && DTPNOReturnTime.Value <= DateTime.Now.AddDays(14))
            {
                TxtPrice.Text = (SelectedBook.PricePerMonth * 2).ToString();
            }
            if (DTPNOReturnTime.Value>DateTime.Now.AddDays(14) && DTPNOReturnTime.Value <= DateTime.Now.AddDays(21))
            {
                TxtPrice.Text = (SelectedBook.PricePerMonth * 3).ToString();
            }
            if (DTPNOReturnTime.Value > DateTime.Now.AddDays(21) && DTPNOReturnTime.Value <= DateTime.Now.AddDays(28))
            {
                TxtPrice.Text = (SelectedBook.PricePerMonth * 4).ToString();
            }
            if (DTPNOReturnTime.Value > DateTime.Now.AddMonths(1) && DTPNOReturnTime.Value <= DateTime.Now.AddMonths(2))
            {
                TxtPrice.Text = (SelectedBook.PricePerMonth * 6).ToString();
            }

        }
        

        //customers list
        private void BtnNewCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.ShowDialog();
        }

        //books list
        private void BtnBooks_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.ShowDialog();
            
        }

        //admins list
        private void BtnAdmins_Click(object sender, EventArgs e)
        {

            Admin admin = new Admin();
            admin.ShowDialog();
        }

        //new order form
        private void BtnNewOrder_Click(object sender, EventArgs e)
        {
            PnlNewOrder.Visible = true;
            
            FillBookList();
            FillCustomerList();

        }

        //close new order form
        private void BtnOrderClose_Click(object sender, EventArgs e)
        {
           
            PnlNewOrder.Visible = false;
            CmbNOBook.Items.Clear();
            CmbNOCustomer.Items.Clear();
            
        }


        //accept new order
        private void BtnNOAccept_Click(object sender, EventArgs e)
        {
            Order NewOrder = new Order
            {
                CustomerId = _context.Customers.FirstOrDefault(c => c.Name + " " + c.Surname == CmbNOCustomer.Text).Id,
                BookId = _context.Books.FirstOrDefault(b => b.Name == CmbNOBook.Text).Id,
                Price = Convert.ToDecimal(TxtPrice.Text),
                RentAt = DateTime.Now,
                ReturnAt = DTPNOReturnTime.Value
            };
            _context.Orders.Add(NewOrder);
            _context.SaveChanges();

            CmbNOBook.Items.Clear();
            CmbNOCustomer.Items.Clear();
            PnlNewOrder.Visible = false;
        }

        //calculate price
        private void DTPNOReturnTime_ValueChanged(object sender, EventArgs e)
        {
            CalcPriceWithReturnDate();
        }

        
    }
}
