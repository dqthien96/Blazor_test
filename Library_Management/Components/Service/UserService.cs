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
        public async Task<List<Book>> GetBookListAsync(int? id)
        {
            if (id == 0)
            {
                var result = await _dbContext.Book
                .OrderByDescending(Book => Book.Id).ToListAsync();
                return result;
            }
            else
            {
                var result = await _dbContext.Book
                .Where(Book => Book.Id == id)
               .OrderByDescending(Book => Book.Id).ToListAsync();
                return result;
            }

        }


        //Create new book
        public async Task AddNewBookAsync(Book book)
        {
            _dbContext.Book.Add(book);
            await _dbContext.SaveChangesAsync();
        }

        //Update book info
        public async Task UpdateNewBookAsync(Book book, int id)
        {
            var resultUpdate = await _dbContext.Book.FindAsync(id);
            if (resultUpdate != null)
            {
                resultUpdate.Title = book.Title;
                resultUpdate.Author = book.Author;
                resultUpdate.Publisher = book.Publisher;
                resultUpdate.PublishedDate = book.PublishedDate;
                resultUpdate.Category = book.Category;
                resultUpdate.Description = book.Description;
                resultUpdate.Available = book.Available;
                await _dbContext.SaveChangesAsync();

            }
        }

        //Delete book
        public async Task DeleteNewBookAsync(int id)
        {
            var result = await _dbContext.Book.FindAsync(id);
            if (result != null)
            {
                _dbContext.Book.Remove(result);
                await _dbContext.SaveChangesAsync();
            }
        }

        //get book by ID
        public async Task<Book> GetBookByIdAsync(int id)
        {
            var bookbyid = await _dbContext.Book.FindAsync(id);
            return bookbyid;
        }


        //get all Category
        public async Task<List<Categorie>> GetCategoryListAsync()
        {
            var result = await _dbContext.Categorie
                .OrderByDescending(Category => Category.Id).ToListAsync();
            return result;
        }


        //Register new user account

        //Get uesr list
        public async Task<List<User>> GetUserListAsync()
        {
            var result = await _dbContext.User
                .OrderByDescending(Users => Users.Id).ToListAsync();
            return result;
        }


        //Create new user

        public async Task AddNewUserAsync(User users)
        {
            var existingUser = await _dbContext.User.FirstOrDefaultAsync(u => u.Username == users.Username);

            if (existingUser != null)
            {

            }
            else
            {

                _dbContext.User.Add(users);
                await _dbContext.SaveChangesAsync();
            }
        }

        //Update user info
        public async Task UpdateNewUserAsync(User users, int id)
        {
            var result_update = await _dbContext.User.FindAsync(id);
            if (result_update != null)
            {

                await _dbContext.SaveChangesAsync();

            }
        }

        //Delete user
        public async Task DeleteNewUserAsync(int id)
        {
            var result = await _dbContext.User.FindAsync(id);
            if (result != null)
            {
                _dbContext.User.Remove(result);
                await _dbContext.SaveChangesAsync();
            }
        }

        //get user by ID
        public async Task<User> GetUserByIdAsync(int id)
        {
            var bookbyid = await _dbContext.User.FindAsync(id);
            return bookbyid;
        }


        //select book Available
        public async Task<List<Book>> GetBookListAvailableAsync()
        {
            var result = await _dbContext.Book
                .Where(Book => Book.Available == true)
                .OrderByDescending(Book => Book.Id)
                .ToListAsync();
            return result;
        }


        //loan book
        public async Task AddBookLoanAsync(BorrowingRecord BorrowingRecord, String Username, int BookId)
        {
            var getinfoUser = await _dbContext.User.FirstOrDefaultAsync(u => u.Username == Username);
            var getinfoBook = await _dbContext.Book.FirstOrDefaultAsync(b => b.Id == BookId);
            // Set BorrowedDate to the current date
            BorrowingRecord.BorrowedDate = DateTime.Today;

            var newRecord = new BorrowingRecord
            {
                UserId = getinfoUser.Id,
                BookId = getinfoBook.Id,
                BorrowedDate = BorrowingRecord.BorrowedDate,
                DueDate = BorrowingRecord.DueDate,
                ReturnedDate = null,
                Status = "Normal",
            };

            _dbContext.BorrowingRecord.Add(newRecord);
            await _dbContext.SaveChangesAsync();
        }

        //get loan book list
        public async Task<List<BorrowingRecord>> GetLoanBookListAsync(String Username)
        {
            if (Username == "admin")
            {
                var result = await _dbContext.BorrowingRecord
                .Where(record => record.Status == "Normal")
                .Include(record => record.Book)
                .Include(record => record.User)
                .OrderByDescending(record => record.Id)
                .ToListAsync();

                return result;
            }
            else
            {
                var getinfoUser = await _dbContext.User.FirstOrDefaultAsync(u => u.Username == Username);
                var result = await _dbContext.BorrowingRecord
                .Where(record => record.UserId == getinfoUser.Id && record.Status == "Normal")
                .OrderByDescending(record => record.Id)
                .Include(record => record.Book)
                .Include(record => record.User)
                .ToListAsync();

                return result;
            }

        }


        public async Task UpdateReturnedDateAsync(BorrowingRecord Book, int id)
        {
            var result_update = await _dbContext.BorrowingRecord.FindAsync(id);
            if (result_update != null)
            {
                result_update.ReturnedDate = Book.ReturnedDate;
                result_update.Status = "Checkout";
                await _dbContext.SaveChangesAsync();

            }
        }
    }
}
