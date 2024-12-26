using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingProject.Domain.Entities;
using TrainingProject.Domain.Interfaces.Repositories;
using TrainingProject.UseCase.Contracts;
using TrainingProject.UseCase.DTOs.Users;
using TrainingProject.UseCase.Exceptions;

namespace TrainingProject.UseCase.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }
        public async Task<UserForResultDto> AddAsync(UserForCreationDto dto)
        {
            var user = await userRepository.SelectAll()
                .Where(x => x.Username == dto.Username)
                .FirstOrDefaultAsync();

            if (user is not null)
            {
                throw new ProjectException(403, "User is already exist");
            }
            
            var mappedUser = mapper.Map<User>(dto);

            var result = await userRepository.CreateAsync(mappedUser);

            return mapper.Map<UserForResultDto>(result);    
        }

        public Task<IEnumerable<UserForResultDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserForResultDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<UserForResultDto> ModifyAsync(Guid id, UserForUpdateDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
