using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingProject.Domain.Entities;
using TrainingProject.Domain.Interfaces.Repositories;
using TrainingProject.Repositories.Repositories;
using TrainingProject.UseCase.Contracts;
using TrainingProject.UseCase.DTOs.Companies;
using TrainingProject.UseCase.DTOs.Users;
using TrainingProject.UseCase.Exceptions;
using TrainingProject.UseCase.Extentions;

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

            var hashedPassword = PasswordHelper.Hash(dto.Password);
            mappedUser.PasswordHash = hashedPassword.Hash;
            mappedUser.Salt = hashedPassword.Salt;
           // mappedUser.InsertedBy = H
            var result = await userRepository.CreateAsync(mappedUser);

            return mapper.Map<UserForResultDto>(result);    
        }

        public async Task<IEnumerable<UserForResultDto>> GetAllAsync()
        {
            var users = await userRepository.SelectAll()
                .AsNoTracking()
                .ToListAsync();

            return mapper.Map<IEnumerable<UserForResultDto>>(users);
        }

        public async Task<UserForResultDto> GetByIdAsync(Guid id)
        {
            var user = await userRepository.SelectAll()
                .Where(x => x.Id == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();

            if (user is null)
                throw new ProjectException(404, "User is not found");

            return mapper.Map<UserForResultDto>(user);
        }

        public async Task<UserForResultDto> ModifyAsync(Guid id, UserForUpdateDto dto)
        {
            var existUser = await this.userRepository.SelectAll()
                                                      .Where(x => x.Id == id)
                                                      .FirstOrDefaultAsync();
            if (existUser is null)
                throw new ProjectException(404, "user is not found");

            var mappedUser = mapper.Map(dto, existUser);
            mappedUser.ChangedAt = DateTime.UtcNow;
            //mappedCompany.ChangedBy = User.

            var result = await userRepository.UpdateAsync(mappedUser);
            return mapper.Map<UserForResultDto>(result);
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            var existUser = await this.userRepository.SelectAll()
                                                      .Where(x => x.Id == id)
                                                      .FirstOrDefaultAsync();
            if (existUser is null)
                throw new ProjectException(404, "user is not found");

            existUser.DeletedAt = DateTime.UtcNow;
            existUser.IsDeleted = true;
            //existUser.DeletedBy = 

            await userRepository.UpdateAsync(existUser);

            return await userRepository.DeleteAsync(id);
        }
        public async Task<UserForResultDto> ChangePasswordAsync(Guid id, UserForChangePasswordDto dto)
        {
            var user = await this.userRepository.SelectById(id);
            if (user is null || !PasswordHelper.Verify(dto.OldPassword, user.Salt, user.PasswordHash))
                throw new ProjectException(404, "Username or Password is incorrect");
            else if (dto.NewPassword != dto.ConfirmedPassword)
                throw new ProjectException(400, "New password and confir password aren't equal");

            var hash = PasswordHelper.Hash(dto.ConfirmedPassword);
            user.Salt = hash.Salt;
            user.PasswordHash = hash.Hash;
            var updatedUser = await this.userRepository.UpdateAsync(user);

            return mapper.Map<UserForResultDto>(updatedUser);
        }
    }
}
