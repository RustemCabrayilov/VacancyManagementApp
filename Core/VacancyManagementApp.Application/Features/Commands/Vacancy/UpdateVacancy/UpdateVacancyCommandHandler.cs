using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagementApp.Application.Abstractions.Services;
using VacancyManagementApp.Application.DTOs.Vacancy;
using VacancyManagementApp.Application.Repositories;

namespace VacancyManagementApp.Application.Features.Commands.Vacancy.UpdateVacancy
{
    public class UpdateVacancyCommandHandler : IRequestHandler<UpdateVacancyCommandRequest, UpdateVacancyCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IVacancyService _vacancyService;

        public UpdateVacancyCommandHandler(IMapper mapper, IVacancyService vacancyService)
        {
            _mapper = mapper;
            _vacancyService = vacancyService;
        }

        public async Task<UpdateVacancyCommandResponse> Handle(UpdateVacancyCommandRequest request, CancellationToken cancellationToken)
        {
            var updateVacancyDto = _mapper.Map<UpdateVacancyDto>(request);

            var dto = await _vacancyService.UpdateVacancyAsync(updateVacancyDto);

            var response = _mapper.Map<UpdateVacancyCommandResponse>(dto);

            return response;
        }
     }
}
