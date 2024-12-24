using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingProject.UseCase.Contracts;
using TrainingProject.UseCase.DTOs.Contacts;

namespace TrainingProject.UseCase.Services
{
    public class ContactService : IContactService
    {
        public Task<ContactForResultDto> AddAsync(ContactForCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ContactForResultDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ContactForResultDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ContactForResultDto> ModifyAsync(ContactForUpdateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
