using TrainingProject.Domain.Entities;
using TrainingProject.Domain.Interfaces.Repositories;

namespace TrainingProject.Repositories.Repositories;

public class CompanyRepository : ICompanyRepository
{
    public Task<Company> CreateAsync(Company company)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Company> SelectAll()
    {
        throw new NotImplementedException();
    }

    public Task<Company> SelectById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Company> UpdateAsync(Company company)
    {
        throw new NotImplementedException();
    }
}
