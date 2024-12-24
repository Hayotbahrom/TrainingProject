using TrainingProject.Domain.Entities;
using TrainingProject.Domain.Interfaces.Repositories;

namespace TrainingProject.Repositories.Repositories;

public class ContactRepository : IContactRepository
{
    public Task<Contact> CreateAsync(Contact contact)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Contact> SelectAll()
    {
        throw new NotImplementedException();
    }

    public Task<Contact> SelectById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Contact> UpdateAsync(Contact contact)
    {
        throw new NotImplementedException();
    }
}
