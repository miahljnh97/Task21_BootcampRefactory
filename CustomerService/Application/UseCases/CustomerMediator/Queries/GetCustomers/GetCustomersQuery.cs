using System;
using MediatR;

namespace CustomerService.Application.UseCases.CustomerMediator.Queries.GetCustomers
{
    public class GetCustomersQuery : IRequest<GetCustomersDTO>
    {
    }
}
