using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingProject.UseCase.Contracts;
using TrainingProject.UseCase.DTOs.Companies;

namespace TrainingProject.UseCase.Services
{
    public class CompanyService : ICompanyService
    {
        public Task<CompanyForResultDto> AddAsync(CompanyForCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CompanyForResultDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CompanyForResultDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<CompanyForResultDto> ModifyAsync(CompanyForUpdateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
