using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TrainingProject.Domain.Entities;
using TrainingProject.Domain.Interfaces.Repositories;
using TrainingProject.UseCase.Contracts;
using TrainingProject.UseCase.DTOs.Contacts;
using TrainingProject.UseCase.Exceptions;

namespace TrainingProject.UseCase.Services;

public class ContactService : IContactService
{
    private readonly IContactRepository contactRepository;
    private readonly ICompanyRepository companyRepository;
    private readonly IMapper mapper;
    public ContactService(
        IContactRepository contactRepository,
        ICompanyRepository companyRepository,
        IMapper mapper)
    {
        this.contactRepository = contactRepository;
        this.companyRepository = companyRepository;
        this.mapper = mapper;
    }
    public async Task<ContactForResultDto> AddAsync(ContactForCreationDto dto)
    {
        var existCompany = await this.companyRepository.SelectAll()
            .Where(x => x.Id == dto.CompanyId)
            .FirstOrDefaultAsync();
        if (existCompany is null)
            throw new ProjectException(404, "Company is not found");

        var contact = await contactRepository.SelectAll()
            .Where(x => x.Email == dto.Email || x.PhoneNumber == dto.PhoneNumber)
            .FirstOrDefaultAsync();
        if (contact is not null)
            throw new ProjectException(403, "Contact is already exist");

        var mappedContact = mapper.Map<Contact>(dto);
        mappedContact.IsDeleted = false;
        mappedContact.InsertedAt = DateTime.UtcNow;
        // mappedContact.InsertedBy = 

        var result = await contactRepository.CreateAsync(mappedContact);

        return mapper.Map<ContactForResultDto>(result);
    }

    public async Task<IEnumerable<ContactForResultDto>> GetAllAsync()
    {
        var contacts = await contactRepository.SelectAll()
            .AsNoTracking()
            .ToListAsync();

        return mapper.Map<IEnumerable<ContactForResultDto>>(contacts);
    }

    public async Task<ContactForResultDto> GetByIdAsync(Guid id)
    {
        var contact = await contactRepository.SelectAll()
            .Where(x => x.Id == id)
            .Include(x => x.Company)
            .FirstOrDefaultAsync();
        if (contact is  null)
            throw new ProjectException(404, "Contact is not found");

        return mapper.Map<ContactForResultDto>(contact);
    }

    public async Task<ContactForResultDto> ModifyAsync(Guid id, ContactForUpdateDto dto)
    {
        var contact = await contactRepository.SelectAll()
            .Where(x => x.Id == id)
            .Include(x => x.Company)
            .FirstOrDefaultAsync();
        if (contact is null)
            throw new ProjectException(404, "Contact is not found");

        var existCompany = await this.companyRepository.SelectAll()
            .Where(x => x.Id == dto.CompanyId)
            .FirstOrDefaultAsync();
        if (existCompany is null)
            throw new ProjectException(404, "Company is not found");

        var mappedcontact = mapper.Map(dto, contact);
        mappedcontact.ChangedAt = DateTime.UtcNow;
        //mappedcontact.ChangedBy = 
        var result = await contactRepository.UpdateAsync(mappedcontact);

        return mapper.Map<ContactForResultDto>(result);
    }

    public async Task<bool> RemoveAsync(Guid id)
    {
        var contact = await contactRepository.SelectAll()
           .Where(x => x.Id == id)
           .Include(x => x.Company)
           .FirstOrDefaultAsync();
        if (contact is null)
            throw new ProjectException(404, "Contact is not found");

        contact.IsDeleted = true;
        contact.DeletedAt = DateTime.UtcNow;
        //contact.DeletedBy = 
        await contactRepository.UpdateAsync(contact);

        return await contactRepository.DeleteAsync(id);
    }
}
