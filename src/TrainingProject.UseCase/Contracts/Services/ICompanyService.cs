using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingProject.UseCase.DTOs.Companies;
using TrainingProject.UseCase.DTOs.Users;

namespace TrainingProject.Domain.Interfaces.Services
{
    public interface ICompanyService
    {
        Task<bool> RemoveAsync(Guid id);
        Task<CompanyForResultDto> GetByIdAsync(Guid id);
        Task<IEnumerable<CompanyForResultDto>> GetAllAsync();
        Task<CompanyForResultDto> AddAsync(CompanyForCreationDto dto);
        Task<CompanyForResultDto> ModifyAsync(CompanyForUpdateDto dto);
    }
}
