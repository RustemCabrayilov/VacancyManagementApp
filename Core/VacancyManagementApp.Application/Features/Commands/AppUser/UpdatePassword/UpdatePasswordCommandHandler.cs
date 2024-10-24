﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacancyManagementApp.Application.Abstractions.Services;
using VacancyManagementApp.Application.Exceptions;

namespace VacancyManagementApp.Application.Features.Commands.AppUser.UpdatePassword
{
    public class UpdatePasswordCommandHandler : IRequestHandler<UpdatePasswordCommandRequest, UpdatePasswordCommandResponse>
    {
        readonly IUserService _userService;

        public UpdatePasswordCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<UpdatePasswordCommandResponse> Handle(UpdatePasswordCommandRequest request, CancellationToken cancellationToken)
        {
            if (!request.Password.Equals(request.ConfirmPassword))
                throw new PasswordChangeFailedException("Please verify the password!");

            await _userService.UpdatePasswordAsync(request.UserId, request.ResetToken, request.Password);

            return new UpdatePasswordCommandResponse
            {
                Message = "Password updated successfully!" 
            };
        }
    }

}
