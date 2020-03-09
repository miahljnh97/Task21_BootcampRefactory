using System;
using System.Threading;
using System.Threading.Tasks;
using CustomerService.Model;
using MediatR;

namespace CustomerService.Application.UseCases.CustomerPayMediator.Queries.GetCustomerPayDTO
{
    public class GetCustomerPayQueryHandler : IRequestHandler<GetCustomerPayQuery, GetCustomerPayDTO>
    {
        private readonly CSContext _context;
        public GetCustomerPayQueryHandler(CSContext context)
        {
            _context = context;
        }

        public async Task<GetCustomerPayDTO> Handle(GetCustomerPayQuery request, CancellationToken cancellationToken)
        {
            var data = await _context.customerPayCard.FindAsync(request.Id);

            if (data == null)
            {
                
                return null;
            }
            else
            {
                
                return new GetCustomerPayDTO
                {
                    Success = true,
                    Message = "Success retreiving data",
                    Data = new CustomerPayData
                    {
                        Id = data.Id,
                        Customer_id = data.customer_id,
                        Name_on_card = data.name_on_card,
                        Exp_month = data.exp_month,
                        Exp_year = data.exp_year,
                        Postal_code = data.postal_code,
                        Credit_card_number = data.credit_card_number
                    }
                };
            }
        }
    }
}
