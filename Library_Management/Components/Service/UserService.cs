using Library_Management.Components.Data;
using Library_Management.Components.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Server;

namespace Library_Management.Components.Service
{
    public class UserService : IUserService
    {
        private readonly BookDbcontext _dbContext;

        public UserService(BookDbcontext dbContext)
        {
            _dbContext = dbContext;
        }


        //Get book list
        public async Task<List<Books>> Getbooklist(int? id)
        {
            if (id == 0)
            {
                var result = await _dbContext.Books
                .OrderByDescending(Books => Books.Id).ToListAsync();
                return result;
            }
            else
            {
                var result = await _dbContext.Books
                .Where(Books => Books.Id == id)
               .OrderByDescending(Books => Books.Id).ToListAsync();
                return result;
            }

        }


        //Create new book
        public async Task Addnewbook(Books books)
        {
            _dbContext.Books.Add(books);
            await _dbContext.SaveChangesAsync();
        }

        //Update book info
        public async Task Updatenewbook(Books books, int id)
        {
            var result_update = await _dbContext.Books.FindAsync(id);
            if (result_update != null)
            {
                result_update.Title = books.Title;
                result_update.Author = books.Author;
                result_update.Publisher = books.Publisher;
                result_update.PublishedDate = books.PublishedDate;
                result_update.Category = books.Category;
                result_update.Description = books.Description;
                result_update.Available = books.Available;
                await _dbContext.SaveChangesAsync();

            }
        }

        //Delete book
        public async Task Deletenewbook(int id)
        {
            var result = await _dbContext.Books.FindAsync(id);
            if (result != null)
            {
                _dbContext.Books.Remove(result);
                await _dbContext.SaveChangesAsync();
            }
        }

        //get book by ID
        public async Task<Books> Getbookbyid(int id)
        {
            var bookbyid = await _dbContext.Books.FindAsync(id);
            return bookbyid;
        }


        //get all Category
        public async Task<List<Categories>> GetCategorylist()
        {
            var result = await _dbContext.Categories
                .OrderByDescending(Category => Category.Id).ToListAsync();
            return result;
        }


        //Register new user account

        //Get uesr list
        public async Task<List<Users>> Getuserlist()
        {
            var result = await _dbContext.Users
                .OrderByDescending(Users => Users.Id).ToListAsync();
            return result;
        }


        //Create new user

        public async Task Addnewuser(Users users)
        {
            var existingUser = await _dbContext.Users.FirstOrDefaultAsync(u => u.Username == users.Username);

            if (existingUser != null)
            {

            }
            else
            {

                _dbContext.Users.Add(users);
                await _dbContext.SaveChangesAsync();
            }
        }

        //Update user info
        public async Task Updatenewuser(Users users, int id)
        {
            var result_update = await _dbContext.Users.FindAsync(id);
            if (result_update != null)
            {

                await _dbContext.SaveChangesAsync();

            }
        }

        //Delete user
        public async Task Deletenewuser(int id)
        {
            var result = await _dbContext.Users.FindAsync(id);
            if (result != null)
            {
                _dbContext.Users.Remove(result);
                await _dbContext.SaveChangesAsync();
            }
        }

        //get user by ID
        public async Task<Users> Getuserbyid(int id)
        {
            var bookbyid = await _dbContext.Users.FindAsync(id);
            return bookbyid;
        }


        //select book Available
        public async Task<List<Books>> GetbooklistAvailable()
        {
            var result = await _dbContext.Books
                .Where(Books => Books.Available == true)
                .OrderByDescending(Books => Books.Id)
                .ToListAsync();
            return result;
        }


        //loan book
        public async Task Addbookloan(BorrowingRecords borrowingRecords, String Username)
        {
            var getinfoUser = await _dbContext.Users.FirstOrDefaultAsync(u => u.Username == Username);

            var newRecord = new BorrowingRecords
            {
                UserId = getinfoUser.Id,
                BookId = borrowingRecords.BookId,
                BorrowedDate = borrowingRecords.BorrowedDate,
                DueDate = borrowingRecords.DueDate,
                ReturnedDate = null,
                Status = "Normal",
            };


            //chance staus of book
            var result_update = await _dbContext.Books.FindAsync(borrowingRecords.BookId);
            if (result_update != null)
            {
                /*result_update.Available = false;*/
                await _dbContext.SaveChangesAsync();

            }

            _dbContext.BorrowingRecords.Add(newRecord);
            await _dbContext.SaveChangesAsync();
        }

        //get loan book list
        public async Task<List<BorrowingRecords>> Getloanbooklist(String Username)
        {
            if (Username == "admin")
            {
                var getinfoUser = await _dbContext.Users.FirstOrDefaultAsync(u => u.Username == Username);
                var query = "SELECT BorrowingRecords.Id, BorrowingRecords.BorrowedDate,BorrowingRecords.DueDate,BorrowingRecords.ReturnedDate,BorrowingRecords.Status," +
                "Books.Id AS BookId, Books.Title AS BookTitle, " +
                "Users.Id AS UserId, Users.Username AS Username " +
                "FROM BorrowingRecords " +
                "INNER JOIN Books ON BorrowingRecords.BookId = Books.Id " +
                "INNER JOIN Users ON BorrowingRecords.UserId = Users.Id ";
                var result = await _dbContext.BorrowingRecords
                .FromSqlRaw(query)
                .Where(BorrowingRecords => BorrowingRecords.Status == "Normal")
                .OrderByDescending(BorrowingRecords => BorrowingRecords.Id)
                .ToListAsync();
                return result;
            }
            else
            {
                var getinfoUser = await _dbContext.Users.FirstOrDefaultAsync(u => u.Username == Username);
                var query = "SELECT BorrowingRecords.Id, BorrowingRecords.BorrowedDate,BorrowingRecords.DueDate,BorrowingRecords.ReturnedDate,BorrowingRecords.Status," +
                "Books.Id AS BookId, Books.Title AS BookTitle, " +
                "Users.Id AS UserId, Users.Username AS Username " +
                "FROM BorrowingRecords " +
                "INNER JOIN Books ON BorrowingRecords.BookId = Books.Id " +
                "INNER JOIN Users ON BorrowingRecords.UserId = Users.Id ";
                var result = await _dbContext.BorrowingRecords
                .FromSqlRaw(query)
                .Where(BorrowingRecords => BorrowingRecords.UserId == getinfoUser.Id)
                .Where(BorrowingRecords => BorrowingRecords.Status == "Normal")
                .OrderByDescending(BorrowingRecords => BorrowingRecords.Id)
                .ToListAsync();
                return result;
            }

        }


        public async Task UpdateReturnedDate(BorrowingRecords books, int id)
        {
            var result_update = await _dbContext.BorrowingRecords.FindAsync(id);
            if (result_update != null)
            {
                result_update.ReturnedDate = books.ReturnedDate;
                result_update.Status = "Checkout";
                await _dbContext.SaveChangesAsync();

            }
        }
    }
}
