using Library_Management.Components.Data;
using Library_Management.Components.Models;
using Microsoft.EntityFrameworkCore;

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
        public async Task<List<Books>> Getbooklist()
        {
            var result = await _dbContext.Books
                .OrderByDescending(Books => Books.Id).ToListAsync();
            return result;
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
            if(result != null) 
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
        public Task Registernewaccount(Users users)
        {
            throw new NotImplementedException();
        }


        //Get book list
        public async Task<List<Users>> Getuserlist()
        {
            var result = await _dbContext.Users
                .OrderByDescending(Users => Users.Id).ToListAsync();
            return result;
        }


        //Create new user
        public async Task Addnewuser(Users users)
        {
            _dbContext.Users.Add(users);
            await _dbContext.SaveChangesAsync();
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


    }
}
