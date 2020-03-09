using System;
using MediatR;

namespace CustomerService.Application.UseCases.CustomerMediator.Queries.GetCustomer
{
    public class GetCustomerQuery : IRequest<GetCustomerDTO>
    {
        public int Id { get; set; }

        public GetCustomerQuery(int id)
        {
            Id = id;
        }
    }
}
