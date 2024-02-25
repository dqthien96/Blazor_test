namespace Library_Management.Components.Data
{
    using Library_Management.Components.Models;
    using Microsoft.EntityFrameworkCore;
    public class Dbcontext : DbContext
    {
        public DbSet<Books> Books { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<BorrowingRecords> BorrowingRecords { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=LAPTOP-P832L3NQ/SQLEXPRESS;Database=Library_data;User Id=;Password=;");
            
            //connect to database
            optionsBuilder.UseSqlServer("Server=LAPTOP-P832L3NQ/SQLEXPRESS;Database=Library_data;");

        }
        
    }

}
