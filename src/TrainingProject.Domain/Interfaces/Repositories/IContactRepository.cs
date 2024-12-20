using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingProject.Domain.Entities;

namespace TrainingProject.Domain.Interfaces.Repositories
{
    public interface IContactRepository
    {
        Task<Contact> CreateAsync(Contact contact);
        Task<Contact> UpdateAsync(Contact contact);
        Task<bool> DeleteAsync(Guid id);
        Task<Contact> SelectById(Guid id);
        IQueryable<Contact> SelectAll();
    }
}
