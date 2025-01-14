using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TrainingProject.Shared.DTOs;
using TrainingProject.Shared.DTOs.Companies;

namespace TrainingProject.Proxy.Services
{
    public class CompanyFormService
    {
        private readonly HttpClient httpClient;
        private string baseUrl = "https://localhost:7143/api/";
        public CompanyFormService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<bool> AddAsync(CompanyForCreationDto model)
        {
            string url = baseUrl + "Companies";
            var jsonContent = new StringContent(System.Text.Json.JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(url, jsonContent);

            if (response.IsSuccessStatusCode)
                return true;
            return false;
        }
        public async Task<IEnumerable<CompanyForResultDto>> GetAllAsync()
        {
            string url = baseUrl + "Companies";
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();

                // Add logging to see the raw response
                Console.WriteLine($"Response Data: {responseData}");

                var result = System.Text.Json.JsonSerializer.Deserialize<IEnumerable<CompanyForResultDto>>(responseData, new JsonSerializerOptions
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
        public async Task<CompanyForResultDto> GetByIdAsync(Guid id)
        {
            string url = $"{baseUrl}Companies/{id}";  // Include the id in the URL
            var response = await httpClient.GetAsync(url);  // Send GET request to the specific contact

            if (response.IsSuccessStatusCode)
            {
                string jsonResult = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<CompanyForResultDto>(jsonResult);
                return result;
            }
            else
            {
                // Handle error response
                throw new HttpRequestException($"Failed to fetch company. Status code: {response.StatusCode}");
            }
        }
        public async Task<bool> DeleteAsync(Guid id)
        {
            string url = $"{baseUrl}Companies/{id}";
            var response = await httpClient.DeleteAsync(url);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
        public async Task<bool> UpdateAsync(Guid id, CompanyForUpdateDto model)
        {
            string url = $"{baseUrl}Companies/{id}";
            var jsonContent = JsonConvert.SerializeObject(model);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await httpClient.PutAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                throw new HttpRequestException($"Failed to update company. Status code: {response.StatusCode}");
            }
        }
    }
}
