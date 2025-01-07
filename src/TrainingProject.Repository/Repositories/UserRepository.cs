using Microsoft.EntityFrameworkCore;
using TrainingProject.Domain.Entities;
using TrainingProject.Domain.Interfaces.Repositories;
using TrainingProject.Infrastructure.DbContexts;

namespace TrainingProject.Repositories.Repositories;

public class UserRepository : IUserRepository
{
    AppDbContext dbContext;
    DbSet<User> users;
    public UserRepository(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
        users = dbContext.Users;
    }
    public async Task<User> CreateAsync(User user)
    {
        await dbContext.AddAsync(user);
        await dbContext.SaveChangesAsync();
        return user;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var result = await users.Where(x => x.IsDeleted == false && x.Id == id).FirstOrDefaultAsync();
        result.IsDeleted = true;
        await dbContext.SaveChangesAsync();
        return true;
    }

    public IQueryable<User> SelectAll()
        => users.Where(x => x.IsDeleted == false);

    public async Task<User> SelectById(Guid id)
    {
        var result = await users.Where(x => x.Id == id).FirstOrDefaultAsync();
        return result;
    }

    public async Task<User> UpdateAsync(User user)
    {
        var  result = dbContext.Update(user).Entity;
        await dbContext.SaveChangesAsync();
        return result;
    }
}
