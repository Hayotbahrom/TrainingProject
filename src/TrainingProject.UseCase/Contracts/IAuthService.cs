using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingProject.UseCase.DTOs.Login;

namespace TrainingProject.UseCase.Contracts
{
    public interface IAuthService
    {
        public Task<LoginForResultDto> AuthenticateAsync(LoginForCreationDto dto);
    }
}
