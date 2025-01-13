using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using TrainingProject.Proxy.ViewModels;
using TrainingProject.Shared.DTOs.Users;

namespace TrainingProject.Proxy.Services;

public class LoginFormService
{
    public string token;
    private string baseUrl = "https://localhost:7143/api/";
    private HttpClient _httpClient;
    public LoginFormService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public async Task<TokenResponse> LoginAsync(UserForCreationDto model)
    {
        string url = baseUrl + "Auth/login";
        var jsonContent = new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(url, jsonContent);
        if (response.IsSuccessStatusCode)
        {
            var responseContent = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var tokenResponse = JsonSerializer.Deserialize<TokenResponse>(responseContent, options);

            token = tokenResponse.Token;

            return tokenResponse;
        }
        else
            throw new Exception($"Login failed! Status code {response.StatusCode}");
    }
    public async Task<bool> RegisterAsync(string username, string password)
    {
        var userCreation = new UserForCreationDto()
        {
            Username = username,
            Password = password
        };

        string url = baseUrl + "Users";
        var jsonContent = new StringContent(JsonSerializer.Serialize(userCreation), Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync(url, jsonContent);

        if (response.IsSuccessStatusCode)
            return true;
        return false;
    }
}
public class TokenResponse
{
    [JsonPropertyName("access_token")]
    public string Token { get; set; }
}
