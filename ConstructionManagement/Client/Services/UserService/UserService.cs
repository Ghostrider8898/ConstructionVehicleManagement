using ConstructionManagement.Client.Pages;
using System.Net.Http.Json;

namespace ConstructionManagement.Client.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;
        public UserService(HttpClient http)
        {
            this._httpClient = http;
        }
        public List<User> Users { get; set; }

        public async Task GetUsers()
        {
            var result = await _httpClient.GetFromJsonAsync<List<User>>("api/user");
            if (result != null)
                Users = result;
        }
    }
}
