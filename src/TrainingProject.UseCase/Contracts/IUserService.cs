﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingProject.UseCase.DTOs.Users;

namespace TrainingProject.UseCase.Contracts
{
    public interface IUserService
    {
        Task<bool> RemoveAsync(Guid id);
        Task<UserForResultDto> GetByIdAsync(Guid id);
        Task<IEnumerable<UserForResultDto>> GetAllAsync();
        Task<UserForResultDto> AddAsync(UserForCreationDto dto);
        Task<UserForResultDto> ModifyAsync( Guid id, UserForUpdateDto dto);
        Task<UserForResultDto> ChangePasswordAsync(Guid id, UserForChangePasswordDto dto);
    }
}
