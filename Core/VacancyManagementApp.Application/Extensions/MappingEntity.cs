using AutoMapper;
using Microsoft.AspNetCore.Identity;
using VacancyManagementApp.Application.DTOs.User;
using VacancyManagementApp.Application.Features.Commands.AppUser.CreateUser;
using VacancyManagementApp.Domain.Entities.Identity;

namespace VacancyManagementApp.Application.Extensions
{
    public class MappingEntity : Profile
    {
        public MappingEntity()
        {
            CreateMap<CreateUserCommandRequest, CreateUserDto>();
            CreateMap<CreateUserResponseDto, CreateUserCommandResponse>();

            CreateMap<CreateUserDto, AppUser>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid().ToString()))
            .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Username))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.NameSurname, opt => opt.MapFrom(src => src.NameSurname));

        }
    }
}





//{
//  "nameSurname": "Hamid Baydamirov",
//  "username": "hamid_baydamirov",
//  "email": "hamid.baydamirov@example.com",
//  "password": "StrongPassword123!",
//  "confirmPassword": "StrongPassword123!"
//}


//{
//    "nameSurname": "testtest1",
//  "username": "test1",
//  "email": "b.hamidd999@gmail.com",
//  "password": "hb001001",
//  "confirmPassword": "hb001001"
//}