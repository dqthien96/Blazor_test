using Library_Management.Components.Models;

namespace Library_Management.Components.Service
{
    public interface IUserService
    {

        //book funtion
        //get all book
        Task<List<Book>> GetBookListAsync(int? id);
        Task AddNewBookAsync(Book books);
        Task<Book> GetBookByIdAsync(int id);
        Task UpdateNewBookAsync(Book book, int id);
        Task DeleteNewBookAsync(int id);

        //get Category
        Task<List<Categorie>> GetCategoryListAsync();


        //user funtion
        Task<List<User>> GetUserListAsync();
        Task AddNewUserAsync(User user);
        Task<User> GetUserByIdAsync(int id);
        Task UpdateNewUserAsync(User users, int id);
        Task DeleteNewUserAsync(int id);
        Task<List<Book>> GetBookListAvailableAsync();
        Task AddBookLoanAsync(BorrowingRecord borrowingRecord, String Username);


        //BorrowingRecords function
        Task<List<BorrowingRecord>> GetLoanBookListAsync(String Username);
        Task UpdateReturnedDateAsync(BorrowingRecord book, int id);
    }
}
