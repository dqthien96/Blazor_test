namespace Library_Management.Components.Data
{
    using Library_Management.Components.Models;
    using Microsoft.EntityFrameworkCore;
    public class Dbcontext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=LAPTOP-P832L3NQ/SQLEXPRESS;Database=Library_data;User Id=;Password=;");
            optionsBuilder.UseSqlServer("Server=LAPTOP-P832L3NQ/SQLEXPRESS;Database=Library_data;");

        }

    }

}
