using Library_Management.Components.Models;

namespace Library_Management.Components.Service
{
    public class UserService:IUserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public async Task<Users> LoginAsync(string username, string password)
        {
            var response = await _httpClient.PostAsJsonAsync("api/user/login", new { username, password });
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Users>();
            }
            return null;
        }
    }
}
