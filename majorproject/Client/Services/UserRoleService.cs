using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using majorproject.Shared.Domain;

namespace majorproject.Client.Services
{
    public class UserRoleService
    {
        private readonly HttpClient _httpClient;

        public UserRoleService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Get all users and its assign role (Index.razor)
        public async Task<List<UserRoleDto>> GetUserRolesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<UserRoleDto>>("api/userroles");
        }

        // Get specific user and its assign role (EditUser.razor)
        public async Task<UserRoleDto> GetUserRoleByIdAsync(string userId)
        {
            return await _httpClient.GetFromJsonAsync<UserRoleDto>($"api/userroles/{userId}");
        }

        // Create, Update, Delete User
        public async Task CreateUserAsync(UserRoleDto userRoleDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/userroles/CreateUser", userRoleDto);
            response.EnsureSuccessStatusCode();
        }

        public async Task UpdateUserAsync(UserRoleDto userRoleDto)
        {
            var response = await _httpClient.PutAsJsonAsync("api/userroles/UpdateUser", userRoleDto);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteUserAsync(string userId)
        {
            var response = await _httpClient.DeleteAsync($"api/userroles/DeleteUser/{userId}");
            response.EnsureSuccessStatusCode();
        }

        // Get all users (Risk Teams)
        public async Task<List<UserRoleDto>> GetUsersAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<UserRoleDto>>("api/userroles/users");
        }

        //Get Roles
        public async Task<List<UserRoleDto>> GetRolesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<UserRoleDto>>("api/userroles/roles");
        }

        public async Task AssignRoleAsync(UserRoleDto userRoleDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/userroles/AssignRole", userRoleDto);
            response.EnsureSuccessStatusCode();
        }

        public async Task RemoveRoleAsync(UserRoleDto userRoleDto)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri($"api/userroles/RemoveRole", UriKind.Relative),
                Content = JsonContent.Create(userRoleDto)
            };

            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
        }

    }

}
