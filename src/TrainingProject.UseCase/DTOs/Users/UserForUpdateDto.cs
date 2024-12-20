using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.UseCase.DTOs.Users
{
    public class UserForUpdateDto
    {
        public Guid Id { get; set; } // To identify which user to update
        public string Username { get; set; }
        public string Password { get; set; } // Optional: Include if password is being updated
        public bool IsActive { get; set; }
        public string ChangedBy { get; set; }
    }
}
