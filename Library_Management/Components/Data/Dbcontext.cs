namespace Library_Management.Components.Data
{
    using Library_Management.Components.Models;
    using Microsoft.EntityFrameworkCore;
    using System;

    public class Dbcontext : DbContext
    {
        public DbSet<Books> Books { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<BorrowingRecords> BorrowingRecords { get; set; }
        public Dbcontext(DbContextOptions<Dbcontext> options) : base(options)
        {
        }

    }

}
