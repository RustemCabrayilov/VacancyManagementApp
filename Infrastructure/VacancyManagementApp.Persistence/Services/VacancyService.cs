using AutoMapper;
using VacancyManagementApp.Application.Abstractions.Services;
using VacancyManagementApp.Application.DTOs.Vacancy;
using VacancyManagementApp.Application.Repositories;
using VacancyManagementApp.Domain.Entities;

namespace VacancyManagementApp.Persistence.Services
{
    public class VacancyService : IVacancyService
    {
        private readonly IVacancyWriteRepository _vacancyWriteRepository;
        private readonly IMapper _mapper;

        public VacancyService(IVacancyWriteRepository vacancyWriteRepository, IMapper mapper)
        {
            _vacancyWriteRepository = vacancyWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateVacancyResponseDto> CreateAsync(CreateVacancyDto model)
        {
            var vacancy = _mapper.Map<Vacancy>(model);
            var isEntityAdded = await _vacancyWriteRepository.AddAsync(vacancy);

            await _vacancyWriteRepository.SaveAsync();

            return new CreateVacancyResponseDto
            {
                Succeeded = isEntityAdded,
                Message = isEntityAdded ? "Vacancy created successfully!" : "Vacancy couldn't be created"
            };
            
        }

    }
}
