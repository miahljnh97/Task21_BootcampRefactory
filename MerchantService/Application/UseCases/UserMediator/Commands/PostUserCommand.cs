using System;
using MediatR;
using MerchantService.Application.UseCases.UserMediator.Request;

namespace MerchantService.Application.UseCases.UserMediator.Commands
{
    public class PostUserCommand : Users, IRequest<UserDTO>
    {
        
    }

    public class Users
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
