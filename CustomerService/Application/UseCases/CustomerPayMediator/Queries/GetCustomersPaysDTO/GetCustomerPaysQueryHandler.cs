using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CustomerService.Application.UseCases.CustomerPayMediator.Queries.GetCustomerPayDTO;
using CustomerService.Application.UseCases.CustomerPayMediator.Queries.GetCustomersPaysDTO;
using CustomerService.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CustomerService.Application.UseCases.CustomerPayMediator.Queries.GetCustomerPays
{
    public class GetCustomerPaysQueryHandler : IRequestHandler<GetCustomerPaysQuery, GetCustomerPaysDTO>
    {
        private readonly CSContext _context;

        public GetCustomerPaysQueryHandler(CSContext context)
        {
            _context = context;
        }

        public async Task<GetCustomerPaysDTO> Handle(GetCustomerPaysQuery request, CancellationToken cancellationToken)
        {
            var data = await _context.customerPayCard.ToListAsync();
            var result = new List<CustomerPayData>();

            foreach (var x in data)
            {
                result.Add(new CustomerPayData
                {
                    Id = x.Id,
                    Customer_id = x.customer_id,
                    Name_on_card = x.name_on_card,
                    Exp_month = x.exp_month,
                    Exp_year = x.exp_year,
                    Postal_code = x.postal_code,
                    Credit_card_number = x.credit_card_number
                });
            }

            
            return new GetCustomerPaysDTO
            {
                Success = true,
                Message = "Success retreiving data",
                Data = result
            };
        }
    }
}
