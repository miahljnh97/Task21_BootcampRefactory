using System;
using MediatR;

namespace CustomerService.Application.UseCases.CustomerPayMediator.Queries.GetCustomersPaysDTO
{
    public class GetCustomerPaysQuery : IRequest<GetCustomerPaysDTO>
    {
        public GetCustomerPaysQuery()
        {
        }
    }
}
