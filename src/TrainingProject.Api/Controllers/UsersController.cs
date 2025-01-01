using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrainingProject.UseCase.Contracts;
using TrainingProject.UseCase.DTOs.Users;

namespace TrainingProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;
        public UsersController(IUserService userService) 
        {
            this.userService = userService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
            => Ok( await userService.GetAllAsync());
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute(Name = "id")] Guid id)
            => Ok(await userService.GetByIdAsync(id));
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] Guid id)
            =>Ok( await userService.RemoveAsync(id));
        
        [HttpPut("{id}")]
        public async Task<IActionResult> ModifyAsync([FromRoute(Name = "id")] Guid id, [FromForm]UserForUpdateDto dto)
            => Ok( await userService.ModifyAsync(id, dto));

        [HttpPost]
        public async Task<IActionResult> AddAsync([FromForm] UserForCreationDto dto)
            => Ok(await userService.AddAsync(dto));
    }
}
