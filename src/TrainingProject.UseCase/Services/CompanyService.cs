using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TrainingProject.Domain.Entities;
using TrainingProject.Domain.Interfaces.Repositories;
using TrainingProject.UseCase.Contracts;
using TrainingProject.UseCase.DTOs.Companies;
using TrainingProject.UseCase.Exceptions;

namespace TrainingProject.UseCase.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository companyRepository;
        private readonly IMapper mapper;
        public CompanyService(IMapper mapper, ICompanyRepository companyRepository)
        {
            this.companyRepository = companyRepository;
            this.mapper = mapper;
        }
        public async Task<CompanyForResultDto> AddAsync(CompanyForCreationDto dto)
        {
            var existCompany = await this.companyRepository.SelectAll()
                .Where(x => x.Name == dto.Name && x.PhoneNumber == dto.PhoneNumber && x.IsDeleted == false)
                .FirstOrDefaultAsync();

            if (existCompany is not null)
                throw new ProjectException(403, "Company is already exist");

            var mappedCompany = mapper.Map<Company>(dto);
            var result = await companyRepository.CreateAsync(mappedCompany);

            return mapper.Map<CompanyForResultDto>(result);
        }

        public async Task<IEnumerable<CompanyForResultDto>> GetAllAsync()
        {
            var companies = await companyRepository.SelectAll()
                .Where(x => x.IsDeleted == false)
                .AsNoTracking()
                .ToListAsync();

            return mapper.Map<IEnumerable<CompanyForResultDto>>(companies);
        }

        public async Task<CompanyForResultDto> GetByIdAsync(Guid id)
        {
            var existCompany = await this.companyRepository.SelectAll()
                                                      .Where(x => x.Id == id && x.IsDeleted == false)
                                                      .FirstOrDefaultAsync();
            if (existCompany is null)
                throw new ProjectException(404, "Company is not found");
            
            return mapper.Map<CompanyForResultDto>(existCompany);
        }

        public async Task<CompanyForResultDto> ModifyAsync(Guid id,CompanyForUpdateDto dto)
        {
            var existCompany = await this.companyRepository.SelectAll()
                                                      .Where(x => x.Id == id && x.IsDeleted == false)
                                                      .FirstOrDefaultAsync();
            if (existCompany is null)
                throw new ProjectException(404, "Company is not found");

            Company mappedCompany = mapper.Map(dto, existCompany);
            mappedCompany.ChangedAt = DateTime.UtcNow;
            //mappedCompany.ChangedBy = User.
            
            var result = await companyRepository.UpdateAsync(mappedCompany);
            return mapper.Map<CompanyForResultDto>(result);
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            var existCompany = await this.companyRepository.SelectAll()
                                                     .Where(x => x.Id == id && x.IsDeleted == false)
                                                     .FirstOrDefaultAsync();
            if (existCompany is null)
                throw new ProjectException(404, "Company is not found");

            existCompany.IsDeleted = true;
            existCompany.DeletedAt = DateTime.UtcNow;
            //existCompany.DeletedBy = 
            await companyRepository.UpdateAsync(existCompany);

            return await companyRepository.DeleteAsync(id); 
        }
    }
}
