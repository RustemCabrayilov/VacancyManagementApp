using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagementApp.Application.Abstractions.Services;
using VacancyManagementApp.Application.DTOs.Vacancy;
using VacancyManagementApp.Application.Features.Commands.Vacancy.CreateVacancy;
using VacancyManagementApp.Application.Repositories;
using VacancyManagementApp.Domain.Entities;

namespace VacancyManagementApp.Persistence.Services
{
    public class VacancyService : IVacancyService
    {
        private readonly IWriteRepository<Vacancy> _vacancyRepository;
        private readonly IMapper _mapper;
        public VacancyService(IWriteRepository<Vacancy> vacancyRepository, IMapper mapper)
        {
            _vacancyRepository = vacancyRepository;
            _mapper = mapper;
        }

        public async Task<CreateVacancyRepsonseDto> CreateAsync(CreateVacancyDto model)
        {
            var vacancy = _mapper.Map<Vacancy>(model);
            var addedentity = await _vacancyRepository.AddAsync(vacancy);
            CreateVacancyRepsonseDto dto = new();
            if (addedentity)
            {
                dto.Succeeded = true;
                dto.Message = "Vacancy created successfully";
            }
            else
            {
                dto.Succeeded = false;
                dto.Message = "Vacancy couldn't be created";
            }

            return dto;
        }
    }
}
