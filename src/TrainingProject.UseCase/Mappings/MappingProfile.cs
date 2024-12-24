using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingProject.Domain.Entities;
using TrainingProject.UseCase.DTOs.Companies;
using TrainingProject.UseCase.DTOs.Contacts;
using TrainingProject.UseCase.DTOs.Users;

namespace TrainingProject.UseCase.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //User
            CreateMap<User, UserForCreationDto>().ReverseMap();
            CreateMap<User, UserForUpdateDto>().ReverseMap();
            CreateMap<User, UserForResultDto>().ReverseMap();

            //Company
            CreateMap<Company, CompanyForCreationDto>().ReverseMap();
            CreateMap<Company, CompanyForUpdateDto>().ReverseMap();
            CreateMap<Company, CompanyForResultDto>().ReverseMap();

            //Contact
            CreateMap<Contact, ContactForCreationDto>().ReverseMap();
            CreateMap<Contact, ContactForUpdateDto>().ReverseMap();
            CreateMap<Contact, ContactForResultDto>().ReverseMap();
        }
    }
}
