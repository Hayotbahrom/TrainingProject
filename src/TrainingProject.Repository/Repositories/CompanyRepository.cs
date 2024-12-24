using Microsoft.EntityFrameworkCore;
using TrainingProject.Domain.Entities;
using TrainingProject.Domain.Interfaces.Repositories;
using TrainingProject.Infrastructure.DbContexts;

namespace TrainingProject.Repositories.Repositories;

public class CompanyRepository : ICompanyRepository
{
    AppDbContext dbContext;
    DbSet<Company> companies;
    public CompanyRepository(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
        companies = dbContext.Companies;
    }
    public async Task<Company> CreateAsync(Company company)
    {
        await dbContext.AddAsync(company);
        await dbContext.SaveChangesAsync();
        return company;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var company = await companies.Where(x => x.Id == id && x.IsDeleted == false).FirstOrDefaultAsync();
        company.IsDeleted = true;
        await dbContext.SaveChangesAsync();
        return true;
    }

    public IQueryable<Company> SelectAll()
        => companies;

    public async Task<Company> SelectById(Guid id)
    {
        var company = await companies.Where(x => x.Id == id).FirstOrDefaultAsync();
        return company;
    }

    public async Task<Company> UpdateAsync(Company company)
    {
        var result = dbContext.Update(company).Entity;
        await dbContext.SaveChangesAsync(); 
        return result;
    }
}
