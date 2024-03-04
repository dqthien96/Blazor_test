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
            var result = await _dbContext.Books.ToListAsync();
            return result;
        }
    }
}
