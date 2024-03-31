namespace Library_Management.Components.Data
{
    using Library_Management.Components.Models;
    using Microsoft.EntityFrameworkCore;
    using System;

    public class BookDbcontext : DbContext
    {
       

        public BookDbcontext(DbContextOptions<BookDbcontext> options) : base(options)
        {
        }
        public DbSet<Book> Book { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Categorie> Categorie { get; set; }
        public DbSet<BorrowingRecord> BorrowingRecord { get; set; }
     

    }

}
