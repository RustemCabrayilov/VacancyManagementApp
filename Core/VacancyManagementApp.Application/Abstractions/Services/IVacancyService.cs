using VacancyManagementApp.Application.DTOs.Vacancy;

namespace VacancyManagementApp.Application.Abstractions.Services
{
    public interface IVacancyService
    {
        Task<CreateVacancyResponseDto> CreateAsync(CreateVacancyDto model);
    }
}
