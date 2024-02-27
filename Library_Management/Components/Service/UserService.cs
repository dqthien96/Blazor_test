using Library_Management.Components.Data;
using Library_Management.Components.Models;
using Microsoft.EntityFrameworkCore;

namespace Library_Management.Components.Service
{
    public class UserService : IUserService
    {
        private readonly DbContext _dbContext;

        public UserService(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Users> LoginAsync(string username, string password)
        {
          /*  var response = await dbcontext.ge("api/user/login", new { username, password });
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Users>();
            }
            return null;*/

            throw new NotImplementedException();    

        }
    }
}
