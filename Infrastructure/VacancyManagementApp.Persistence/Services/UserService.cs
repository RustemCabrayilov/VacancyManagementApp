using AutoMapper;
using Microsoft.AspNetCore.Identity;
using VacancyManagementApp.Application.Abstractions.Services;
using VacancyManagementApp.Application.DTOs.User;
using U = VacancyManagementApp.Domain.Entities.Identity;

namespace VacancyManagementApp.Persistence.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<U.AppUser> _userManager;
        private readonly IMapper _mapper;

        public UserService(UserManager<U.AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<CreateUserResponseDto> CreateAsync(CreateUserDto model)
        {
            var identityUser = _mapper.Map<U.AppUser>(model);

            IdentityResult result = await _userManager.CreateAsync(identityUser, model.Password);

            CreateUserResponseDto response = new() { Succeeded = result.Succeeded };

            if (result.Succeeded)
                response.Message = "User created successfully!";
            else
                foreach (var error in result.Errors)
                    response.Message += $"{error.Code} - {error.Description}\n";

            return response;
        }
    }
}
