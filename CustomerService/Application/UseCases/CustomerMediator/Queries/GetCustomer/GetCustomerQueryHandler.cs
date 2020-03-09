using System;
using System.Threading;
using System.Threading.Tasks;
using CustomerService.Model;
using MediatR;

namespace CustomerService.Application.UseCases.CustomerMediator.Queries.GetCustomer
{
    public class GetCustomerQueryHandler : IRequestHandler<GetCustomerQuery, GetCustomerDTO>
    {
        private readonly CSContext _context;

        public GetCustomerQueryHandler(CSContext context)
        {
            _context = context;
        }

        public async Task<GetCustomerDTO> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
        {
            var data = await _context.customers.FindAsync(request.Id);

            if (data == null)
            {
                return null;
            }
            else
            {
                return new GetCustomerDTO
                {
                    Success = true,
                    Message = "Success retreiving data",
                    Data = new CustomerData
                    {
                        Id = data.Id,
                        Full_name = data.full_name,
                        Username = data.username,
                        Birthdate = data.birthdate,
                        Password = data.password,
                        Gender = Enum.GetName(typeof(Gender), data.sex),
                        Email = data.email,
                        Phone_number = data.phone_number
                    }
                };
            }
        }
    }
}