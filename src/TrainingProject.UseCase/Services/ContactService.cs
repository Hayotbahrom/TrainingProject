using AutoMapper;
using TrainingProject.Domain.Interfaces.Repositories;
using TrainingProject.UseCase.Contracts;
using TrainingProject.UseCase.DTOs.Contacts;

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
        
        //implement here with file relation
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ContactForResultDto>> GetAllAsync()
    {

        throw new NotImplementedException();
    }

    public Task<ContactForResultDto> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<ContactForResultDto> ModifyAsync(Guid id, ContactForUpdateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RemoveAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
