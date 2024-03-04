using Library_Management.Components.Models;

namespace Library_Management.Components.Service
{
    public interface IUserService
    {

        
        //get all book
        Task<List<Books>> Getbooklist();


    }
}
