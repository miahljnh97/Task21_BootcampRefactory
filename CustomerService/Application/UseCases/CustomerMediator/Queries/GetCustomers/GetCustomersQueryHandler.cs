using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CustomerService.Application.UseCases.CustomerMediator.Queries.GetCustomer;
using CustomerService.Model;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CustomerService.Application.UseCases.CustomerMediator.Queries.GetCustomers
{
    public class GetCustomersQueryHandler : IRequestHandler<GetCustomersQuery, GetCustomersDTO>
    {
        private readonly CSContext _context;

        public GetCustomersQueryHandler(CSContext context)
        {
            _context = context;
        }


        public async Task<GetCustomersDTO> Handle(GetCustomersQuery request, CancellationToken cancellationToken)
        {
            var data = await _context.customers.ToListAsync();
            var result = new List<CustomerData>();

            foreach (var x in data)
            {
                result.Add(new CustomerData
                {
                    Id = x.Id,
                    Full_name = x.full_name,
                    Username = x.username,
                    Birthdate = x.birthdate,
                    Password = x.password,
                    Gender = Enum.GetName(typeof(Gender), x.sex),
                    Email = x.email,
                    Phone_number = x.phone_number
                });
            }

            return new GetCustomersDTO
            {
                Success = true,
                Message = "Success retreiving data",
                Data = result
            };
        }
    }
}
