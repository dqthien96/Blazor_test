using System.ComponentModel.DataAnnotations;

namespace Library_Management.Components.Models
{
    public class Book
    {
        [Key]
        public int idB { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }

    }
}
