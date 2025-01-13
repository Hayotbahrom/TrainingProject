using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.Shared.DTOs.Users
{
    public class UserForUpdateDto
    {
        public string Username { get; set; }
        public bool IsActive { get; set; }
    }
}
