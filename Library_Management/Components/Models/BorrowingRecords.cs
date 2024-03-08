namespace Library_Management.Components.Models
{
    public class BorrowingRecords
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? BookId { get; set; }
        public DateTime BorrowedDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnedDate { get; set; }
        public string? Status { get; set; }


    
    }
 

}
