using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.Shared.DTOs.Contacts
{
    public class ContactForUpdateDto
    {
            public Guid CompanyId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Position { get; set; }
            public string PhoneNumber { get; set; }
            [EmailAddress]
            public string Email { get; set; }
            public string Notes { get; set; }
    }
}
