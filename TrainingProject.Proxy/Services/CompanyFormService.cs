using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
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
            var jsonContent = new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(url, jsonContent);

            if (response.IsSuccessStatusCode)
                return true;
            return false;
        }
    }
}
