using Microsoft.EntityFrameworkCore;
using TrainingProject.Domain.Entities;
using TrainingProject.Domain.Interfaces.Repositories;
using TrainingProject.Infrastructure.DbContexts;

namespace TrainingProject.Repositories.Repositories;

public class ContactRepository : IContactRepository
{
    AppDbContext dbContext;
    DbSet<Contact> contacts;
    public ContactRepository(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
        contacts = dbContext.Contacts;
    }
    public async Task<Contact> CreateAsync(Contact contact)
    {
        await dbContext.AddAsync(contact);
        await dbContext.SaveChangesAsync();
        return contact;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var user = await contacts.Where(x => x.IsDeleted == false && x.Id == id).FirstOrDefaultAsync();
        user.IsDeleted = true;
        await dbContext.SaveChangesAsync();
        return true;
    }

    public IQueryable<Contact> SelectAll()
        => contacts.Where(x => x.IsDeleted == false);

    public async Task<Contact> SelectById(Guid id)
    {
        var result = await contacts.Where(x => x.Id == id).FirstOrDefaultAsync();
        return result;
    }

    public async Task<Contact> UpdateAsync(Contact contact)
    {
        var result = dbContext.Update(contact).Entity;
        await dbContext.SaveChangesAsync();
        return result;
    }
}
