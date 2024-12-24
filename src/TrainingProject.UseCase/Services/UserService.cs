using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingProject.UseCase.Contracts;
using TrainingProject.UseCase.DTOs.Users;

namespace TrainingProject.UseCase.Services
{
    public class UserService : IUserService
    {
        public Task<UserForResultDto> AddAsync(UserForCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserForResultDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserForResultDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<UserForResultDto> ModifyAsync(UserForUpdateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
