using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library_project.Models;

namespace library_project.DAL
{
    class LibraryContext: DbContext
    {
        public LibraryContext() : base("LibraryContext")
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
