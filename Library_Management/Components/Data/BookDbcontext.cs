namespace Library_Management.Components.Data
{
    using Library_Management.Components.Models;
    using Microsoft.EntityFrameworkCore;
    using System;

    public class BookDbcontext : DbContext
    {
       
       // public DbSet<BorrowingRecords> BorrowingRecords { get; set; }
        public BookDbcontext(DbContextOptions<BookDbcontext> options) : base(options)
        {
        }
        public DbSet<Books> Books { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<BorrowingRecords> BorrowingRecords { get; set; }
     

    }

}
