using System;
using CustomerService.Application.UseCases.CustomerPayMediator.Request;
using MediatR;

namespace CustomerService.Application.UseCases.CustomerPayMediator.Commands
{
    public class DeleteCustomerPayCommand : IRequest<CustomerPayDTO>
    {
        public int Id { get; set; }

        public DeleteCustomerPayCommand(int id)
        {
            Id = id;
        }
    }
}
