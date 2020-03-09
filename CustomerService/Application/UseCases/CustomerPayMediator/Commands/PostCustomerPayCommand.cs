using System;
using CustomerService.Application.UseCases.CustomerPayMediator.Queries.GetCustomerPayDTO;
using CustomerService.Model;
using MediatR;

namespace CustomerService.Application.UseCases.CustomerPayMediator.Commands
{
    public class PostCustomerPayCommand : CommandDTO<Customers_Payment_Card>, IRequest<GetCustomerPayDTO>
    {

    }
}
