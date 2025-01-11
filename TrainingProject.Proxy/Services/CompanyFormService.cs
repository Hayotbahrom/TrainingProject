using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.Proxy.Services
{
    public class CompanyFormService
    {
        private readonly HttpClient httpClient;
        public CompanyFormService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public Task AddAsync()
        {
            return Task.CompletedTask;
        }
    }
}
