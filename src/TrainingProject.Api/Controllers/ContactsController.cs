using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrainingProject.Api.Models;
using TrainingProject.UseCase.Contracts;
using TrainingProject.UseCase.DTOs.Contacts;
using TrainingProject.UseCase.DTOs.Users;

namespace TrainingProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService contactService;
        public ContactsController(IContactService contactService)
        {
            this.contactService = contactService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
            => Ok(await contactService.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute(Name = "id")] Guid id)
            => Ok(new Response
            {
                StatusCode = 200,
                Message = "Success",
                Data = await contactService.GetByIdAsync(id)
            });

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] Guid id)
            => Ok(new Response
            {
                StatusCode = 200,
                Message = "Success",
                Data = await contactService.RemoveAsync(id)
            });

        [HttpPut("{id}")]
        public async Task<IActionResult> ModifyAsync([FromRoute(Name = "id")] Guid id, ContactForUpdateDto dto)
            => Ok(new Response
            {
                StatusCode = 200,
                Message = "Success",
                Data = await contactService.ModifyAsync(id, dto)
            });

        [HttpPost]
        public async Task<IActionResult> AddAsync( ContactForCreationDto dto)
            => Ok(new Response
            {
                StatusCode = 200,
                Message = "Success",
                Data = await contactService.AddAsync(dto)
            });
    }
}
