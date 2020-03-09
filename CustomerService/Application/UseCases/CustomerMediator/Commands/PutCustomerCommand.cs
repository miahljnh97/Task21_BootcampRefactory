using System;
using CustomerService.Application.UseCases.CustomerMediator.Queries.GetCustomer;
using CustomerService.Model;
using MediatR;

namespace CustomerService.Application.UseCases.CustomerMediator.Commands
{
    public class PutCustomerCommand : CommandDTO<Customers>, IRequest<GetCustomerDTO>
    {
    }
}
