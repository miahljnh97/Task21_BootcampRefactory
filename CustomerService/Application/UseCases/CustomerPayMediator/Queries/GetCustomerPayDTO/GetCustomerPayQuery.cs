using System;
using MediatR;

namespace CustomerService.Application.UseCases.CustomerPayMediator.Queries.GetCustomerPayDTO
{
    public class GetCustomerPayQuery : IRequest<GetCustomerPayDTO>
    {
        public int Id { get; set; }

        public GetCustomerPayQuery(int id)
        {
            Id = id;
        }
    }
}