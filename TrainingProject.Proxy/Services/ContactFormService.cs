using System.Net.Http;
using System.Text.Json;
using System.Text;
using TrainingProject.Shared.DTOs.Contacts;
using Newtonsoft.Json;

namespace TrainingProject.Proxy.Services;

public class ContactFormService
{
    private readonly HttpClient httpClient;
    private string baseUrl = "https://localhost:7143/api/";
    public ContactFormService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }
    public async Task<bool> AddAsync(ContactForCreationDto model)
    {
        string url = baseUrl + "Contacts";
        var jsonContent = new StringContent(System.Text.Json.JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");
        var response = await httpClient.PostAsync(url, jsonContent);

        if (response.IsSuccessStatusCode)
            return true;
        return false;
    }
    public async Task<IEnumerable<ContactForResultDto>> GetAllAsync()
    {
        string url = baseUrl + "Contacts";
        var response = await httpClient.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            string responseData = await response.Content.ReadAsStringAsync();

            // Add logging to see the raw response
            Console.WriteLine($"Response Data: {responseData}");

            var result = System.Text.Json.JsonSerializer.Deserialize<IEnumerable<ContactForResultDto>>(responseData, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return result;
        }
        else
        {
            throw new HttpRequestException($"Failed to fetch data: {response.StatusCode} - {response.ReasonPhrase}");
        }
    }
    public async Task<ContactForResultDto> GetByIdAsync(Guid id)
    {
        string url = $"{baseUrl}Contacts/{id}";  // Include the id in the URL
        var response = await httpClient.GetAsync(url);  // Send GET request to the specific contact

        if (response.IsSuccessStatusCode)
        {
            string jsonResult = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ContactForResultDto>(jsonResult);
            return result;
        }
        else
        {
            // Handle error response
            throw new HttpRequestException($"Failed to fetch contact. Status code: {response.StatusCode}");
        }
    }
    public async Task<bool> UpdateAsync(Guid id, ContactForUpdateDto model)
    {
        string url = $"{baseUrl}Contacts/{id}"; 
        var jsonContent = JsonConvert.SerializeObject(model);  
        var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");  

        var response = await httpClient.PutAsync(url, content); 

        if (response.IsSuccessStatusCode)
        {
            return true;  
        }
        else
        {
            throw new HttpRequestException($"Failed to update contact. Status code: {response.StatusCode}");
        }
    }

}

