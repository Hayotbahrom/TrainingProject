using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingProject.UseCase.DTOs.Contacts;
using TrainingProject.UseCase.DTOs.Users;

namespace TrainingProject.UseCase.Contracts
{
    public interface IContactService
    {
        Task<bool> RemoveAsync(Guid id);
        Task<ContactForResultDto> GetByIdAsync(Guid id);
        Task<IEnumerable<ContactForResultDto>> GetAllAsync();
        Task<ContactForResultDto> AddAsync(ContactForCreationDto dto);
        Task<ContactForResultDto> ModifyAsync(ContactForUpdateDto dto);
    }
}
