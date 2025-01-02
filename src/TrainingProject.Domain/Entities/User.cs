using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Salt {  get; set; }
        public bool IsActive { get; set; }
        public DateTime? ChangedAt { get; set; }
        public string? ChangedBy { get; set; }
        public DateTime? InsertedAt  { get; set; } = DateTime.UtcNow;
        public string? InsertedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? DeletedBy { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
