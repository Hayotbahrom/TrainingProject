﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrainingProject.Api.Models;
using TrainingProject.UseCase.Contracts;
using TrainingProject.UseCase.DTOs.Users;

namespace TrainingProject.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;
        public UsersController(IUserService userService) 
        {
            this.userService = userService;
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
            => Ok( new Response
            {
                StatusCode = 200,
                Message = "Success",
                Data = await userService.GetAllAsync() 
            });
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute(Name = "id")] Guid id)
            => Ok(new Response
            {
                StatusCode = 200,
                Message = "Success",
                Data = await userService.GetByIdAsync(id)
            });
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] Guid id)
            => Ok(new Response
            {
                StatusCode = 200,
                Message = "Success",
                Data = await userService.RemoveAsync(id)
            });

        [HttpPut("{id}")]
        public async Task<IActionResult> ModifyAsync([FromRoute(Name = "id")] Guid id, [FromForm]UserForUpdateDto dto)
            => Ok(new Response
            {
                StatusCode = 200,
                Message = "Success",
                Data = await userService.ModifyAsync(id, dto)
            });

        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] UserForCreationDto dto)
            => Ok(new Response
            {
                StatusCode = 200,
                Message = "Success",
                Data = await userService.AddAsync(dto)
            });
        [HttpPut("change-password")]
        public async Task<IActionResult> ChangePasswordAsync(Guid id, UserForChangePasswordDto dto)
            => Ok(new Response
            {
                StatusCode = 200,
                Message = "Success",
                Data = await userService.ChangePasswordAsync(id, dto)
            });
    }
}
