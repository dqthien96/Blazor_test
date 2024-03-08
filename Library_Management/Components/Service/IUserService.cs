using Library_Management.Components.Models;

namespace Library_Management.Components.Service
{
    public interface IUserService
    {

        //book funtion
        //get all book
        Task<List<Books>> Getbooklist(int? id);
        Task Addnewbook(Books books);
        Task<Books> Getbookbyid(int id);
        Task Updatenewbook(Books books, int id);
        Task Deletenewbook(int id);

        //get Category
        Task<List<Categories>> GetCategorylist();


        //user funtion
        Task<List<Users>> Getuserlist();
        Task Addnewuser(Users users);
        Task<Users> Getuserbyid(int id);
        Task Updatenewuser(Users users, int id);
        Task Deletenewuser(int id);
        Task<List<Books>> GetbooklistAvailable();
        Task Addbookloan(BorrowingRecords borrowingRecords, String Username);


        //BorrowingRecords function
        Task<List<BorrowingRecords>> Getloanbooklist(String Username);
        Task UpdateReturnedDate(BorrowingRecords books, int id);
    }
}
