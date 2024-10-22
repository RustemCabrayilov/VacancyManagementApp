using VacancyManagementApp.Application.DTOs.Vacancy;
using VacancyManagementApp.Application.Features.Commands.Vacancy.CreateVacancy;

namespace VacancyManagementApp.Application.Abstractions.Services
{
    public interface IVacancyService
    {
        Task<CreateVacancyRepsonseDto> CreateAsync(CreateVacancyDto model);
    }
}
