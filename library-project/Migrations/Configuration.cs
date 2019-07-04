namespace library_project.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using library_project.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<library_project.DAL.LibraryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(library_project.DAL.LibraryContext context)
        {
            Customer customer1 = new Customer
            {
                Name = "Mamed",
                Surname = "Mamedov",
                PhoneNumber = "0555556677",
                Birthday = new DateTime(1993, 05, 15),
                CreateAt = DateTime.Now
            };

            context.Customers.AddOrUpdate(customer1);
            context.SaveChanges();

            Book book1 = new Book
            {
                Name = "History",
                PricePerMonth = 5,
                Count = 5
            };


            context.Books.AddOrUpdate(book1);
            context.SaveChanges();

            Admin admin1 = new Admin
            {
                Name = "Hetem",
                Surname = "Hetemov",
                Nickname = "hetemh",
                Password = "hetemh"

            };
            context.Admins.AddOrUpdate(admin1);
            context.SaveChanges();

            Order order1 = new Order
            {
                CustomerId = customer1.Id,
                BookId = book1.Id,
                RentAt = DateTime.Now,
                ReturnAt = DateTime.Now.AddDays(10)
            };

            context.Orders.AddOrUpdate(order1);
            context.SaveChanges();
        }
    }
}
