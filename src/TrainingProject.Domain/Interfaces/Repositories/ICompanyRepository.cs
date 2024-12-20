using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingProject.Domain.Entities;

namespace TrainingProject.Domain.Interfaces.Repositories
{
    public interface ICompanyRepository
    {
        Task<Company> CreateAsync(Company company);
        Task<Company> UpdateAsync(Company company);
        Task<bool> DeleteAsync(Guid id);
        Task<Company> SelectById(Guid id);
        IQueryable<Company> SelectAll();
    }
}
