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
    public partial class Books : Form
    {

        private readonly LibraryContext _context;
        private library_project.Models.Book SelectedBook;
        public Books()
        {
            InitializeComponent();

            _context = new LibraryContext();

            FillBookList();
        }

        //fill function
        private void FillBookList()
        {
            DgvBooks.Rows.Clear();

            foreach (var book in _context.Books.ToList())
            {
                DgvBooks.Rows.Add(book.Id,
                                  book.Name,
                                  book.Count,
                                  book.PricePerMonth);
            }
        }

        //reset books list function
        private void ResetBookList()
        {
            TxtNBName.Text = string.Empty;
            TxtNBCount.Text = string.Empty;
            TxtNBPrice.Text = string.Empty;
        }

        //reset creating new book function
        private void ResetNewBookForm()
        {
            TxtNBName.Text = string.Empty;
            TxtNBPrice.Text = string.Empty;
            TxtNBCount.Text = string.Empty;
        }

        //create new book button event
        private void BtnNewBook_Click(object sender, EventArgs e)
        {
            PnlNewBook.Visible = true;
            TxtNBCount.Text = string.Empty;
            TxtNBName.Text = string.Empty;
            TxtNBPrice.Text = string.Empty;
        }

        //creating new book close event
        private void BtnNBClose_Click(object sender, EventArgs e)
        {
            PnlNewBook.Visible = false;
        }

        //add new created book to database event
        private void BtnAddNewBook_Click(object sender, EventArgs e)
        {
            var book = new library_project.Models.Book();


           
            book.Name = TxtNBName.Text;
            book.Count = Convert.ToInt32(TxtNBCount.Text);
            book.PricePerMonth = Convert.ToInt32(TxtNBPrice.Text);

            _context.Books.Add(book);
            _context.SaveChanges();

            PnlNewBook.Visible = false;
            ResetBookList();
            FillBookList();
            ResetNewBookForm();
            MessageBox.Show("New Book Created Successfully!");
        }

        //delete an existing book from database event
        private void BtnDeleteBook_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure?", "Delete?", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                _context.Books.Remove(SelectedBook);
                _context.SaveChanges();

                ResetBookList();
                FillBookList();

                MessageBox.Show("Successfully deleted!");
            }
        }

        //selection an existing book event
        private void DgvBooks_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int Id = Convert.ToInt32(DgvBooks.Rows[e.RowIndex].Cells[0].Value.ToString());
            SelectedBook = _context.Books.Find(Id);
        }

        //update an existing book info event
        private void BtnUpdateBook_Click(object sender, EventArgs e)
        {
                PnlNewBook.Visible = true;
                BtnAddNewBook.Visible = false;
                BtnBookUpd.Visible = true;

            
                TxtNBName.Text = SelectedBook.Name;
                TxtNBPrice.Text = SelectedBook.PricePerMonth.ToString();
                TxtNBCount.Text = SelectedBook.Count.ToString();

        }

        //update an existing book info function
        private void BtnBookUpd_Click(object sender, EventArgs e)
        {
            
                SelectedBook.Name = TxtNBName.Text;
                SelectedBook.PricePerMonth = Convert.ToInt32(TxtNBPrice.Text);
                SelectedBook.Count = Convert.ToInt32(TxtNBCount.Text);

                _context.SaveChanges();
            

            PnlNewBook.Visible = false;
            ResetBookList();
            FillBookList();
            ResetNewBookForm();

            MessageBox.Show("Information successfully updated!");
        }
        
        //new book form close event
        private void BtnNBClose_Click_1(object sender, EventArgs e)
        {
            PnlNewBook.Visible = false;
        }

        //book search function
        private void SearchBook()
        {
            DgvBooks.Rows.Clear();

            List<library_project.Models.Book> books = _context.Books.Where(b => b.Name.Contains(TxtSearchBook.Text)).ToList();

            foreach (var item in books)
            {
                DgvBooks.Rows.Add(item.Id,
                                item.Name,
                                item.PricePerMonth,
                                item.Count);
            }
        }

        private void TxtSearchBook_TextChanged(object sender, EventArgs e)
        {
            SearchBook();
        }

    }
}