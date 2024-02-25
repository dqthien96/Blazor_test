using Library_Management.Components.Models;

namespace Library_Management.Components.Service
{
    public interface IUserService
    {
        Task<Users> LoginAsync(string username, string password);
    }
}
