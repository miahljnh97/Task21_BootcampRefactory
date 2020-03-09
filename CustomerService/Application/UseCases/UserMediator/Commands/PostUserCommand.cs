using System;
using MediatR;
using CustomerService.Application.UseCases.UserMediator.Request;

namespace CustomerService.Application.UseCases.UserMediator.Commands
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
