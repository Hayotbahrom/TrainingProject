﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingProject.Domain.Entities;

namespace TrainingProject.UseCase.DTOs.Contacts
{
    public class ContactForResultDto
    {
            public Guid Id { get; set; }
            public Guid CompanyId { get; set; }
            public Company Company { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Position { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
            public string Notes { get; set; }
            //public DateTime ChangedAt { get; set; }
            //public string ChangedBy { get; set; }
            public DateTime InsertedAt { get; set; }
            public string InsertedBy { get; set; }
            public DateTime DeletedAt { get; set; }
            public string DeletedBy { get; set; }
    }
}
