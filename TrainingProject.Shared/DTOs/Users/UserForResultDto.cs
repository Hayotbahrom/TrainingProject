using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.Shared.DTOs.Users
{
    public class UserForResultDto
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public bool IsActive { get; set; }
        public DateTime InsertedAt { get; set; }
        public string InsertedBy { get; set; }
        public DateTime ChangedAt { get; set; }
        public string ChangedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
