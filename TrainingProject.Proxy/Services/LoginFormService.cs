using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TrainingProject.Proxy.ViewModels;

namespace TrainingProject.Proxy.Services
{
    public class LoginFormService
    {
        private HttpClient _httpClient;
        public LoginFormService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<TokenResponse> LoginAsync(LoginViewModel model)
        {
            string url = "https://localhost:7143/api/Auth/login";
            var jsonContent = new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");

            var response = await _httpClient.PatchAsync(url, jsonContent);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<TokenResponse>(responseContent);
            }
            else
                throw new Exception($"Login failed! Status code {response.StatusCode}");
        }
        public Task RegisterAsync()
        {

        }
    }
    public class TokenResponse
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
