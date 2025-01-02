using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrainingProject.Api.Models;
using TrainingProject.UseCase.Contracts;
using TrainingProject.UseCase.DTOs.Companies;
using TrainingProject.UseCase.DTOs.Users;

namespace TrainingProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly ICompanyService companyService;
        public CompaniesController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
            => Ok(new Response
            {
                StatusCode = 200,
                Message = "Success",
                Data = await companyService.GetAllAsync()
            });

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute(Name = "id")] Guid id)
            => Ok(new Response
            {
                StatusCode = 200,
                Message = "Success",
                Data = await companyService.GetByIdAsync(id)
            });

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute(Name = "id")] Guid id)
            => Ok(new Response
            {
                StatusCode = 200,
                Message = "Success",
                Data = await companyService.RemoveAsync(id)
            });

        [HttpPut("{id}")]
        public async Task<IActionResult> ModifyAsync([FromRoute(Name = "id")] Guid id, [FromForm] CompanyForUpdateDto dto)
            => Ok(new Response
            {
                StatusCode = 200,
                Message = "Success",
                Data = await companyService.ModifyAsync(id, dto)
            });

        [HttpPost]
        public async Task<IActionResult> AddAsync([FromForm] CompanyForCreationDto dto)
            => Ok(new Response
            {
                StatusCode = 200,
                Message = "Success",
                Data = await companyService.AddAsync(dto)
            });
    }
}
