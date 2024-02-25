namespace Library_Management.Components.Data
{
    using Library_Management.Components.Models;
    using Microsoft.EntityFrameworkCore;
    public class Dbcontext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=your_server_ip;Database=your_database_name;User Id=your_username;Password=your_password;");
        }
 
    }

}
