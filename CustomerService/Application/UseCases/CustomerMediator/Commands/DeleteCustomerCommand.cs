using System;
using CustomerService.Application.UseCases.CustomerMediator.Request;
using MediatR;

namespace CustomerService.Application.UseCases.CustomerMediator.Commands
{
    public class DeleteCustomerCommand : IRequest<CustomerDTO>
    {
        public int Id { get; set; }
        public DeleteCustomerCommand(int id)
        {
            Id = id;
        }
    }
}
