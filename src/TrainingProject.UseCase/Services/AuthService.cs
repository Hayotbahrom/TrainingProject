using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TrainingProject.Domain.Entities;
using TrainingProject.Domain.Interfaces.Repositories;
using TrainingProject.UseCase.Contracts;
using TrainingProject.UseCase.DTOs.Login;
using TrainingProject.UseCase.Exceptions;
using TrainingProject.UseCase.Extentions;

namespace TrainingProject.UseCase.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository userRepository;
        private readonly IConfiguration _configuration;
        public AuthService(IUserRepository userRepository, IConfiguration configuration)
        {
            this.userRepository = userRepository;
            _configuration = configuration;
        }
        public async Task<LoginForResultDto> AuthenticateAsync(LoginForCreationDto dto)
        {
            var user = await userRepository.SelectAll()
                .Where(x => x.Username == dto.Username)
                .FirstOrDefaultAsync();

            if (user is not null)
            {
                var hashedPassword = PasswordHelper.Verify(dto.Password, user.Salt, user.PasswordHash);
                if (hashedPassword is false)
                {
                    throw new ProjectException(400, "username or Password is incorrect");
                }
                else
                {
                    return new LoginForResultDto
                    {
                        Token = GenerateToken(user)
                    };
                }
            }
            else
                throw new ProjectException(400, "Username or Password is incorrect");
        }
        public string GenerateToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(_configuration["JWT:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("Id", user.Id.ToString()),
                    //new Claim(ClaimTypes.Role, user.Role.ToString()),  // Use the role passed as an argument
                }),
                Audience = _configuration["JWT:Audience"],
                Issuer = _configuration["JWT:Issuer"],
                IssuedAt = DateTime.UtcNow,
                Expires = DateTime.UtcNow.AddMinutes(double.Parse(_configuration["JWT:Expire"])),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
