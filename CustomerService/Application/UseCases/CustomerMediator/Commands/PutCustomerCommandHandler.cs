using System;
using System.Threading;
using System.Threading.Tasks;
using CustomerService.Application.UseCases.CustomerMediator.Queries.GetCustomer;
using CustomerService.Model;
using MediatR;

namespace CustomerService.Application.UseCases.CustomerMediator.Commands
{
    public class PutCustomerCommandHandler : IRequestHandler<PutCustomerCommand, GetCustomerDTO>
    {
        private readonly CSContext _context;

        public PutCustomerCommandHandler(CSContext context)
        {
            _context = context;
        }

        public async Task<GetCustomerDTO> Handle(PutCustomerCommand request, CancellationToken cancellationToken)
        {
            var data = await _context.customers.FindAsync(request.Data.Attributes.Id);

            data.full_name = request.Data.Attributes.full_name;
            data.username = request.Data.Attributes.username;
            data.birthdate = request.Data.Attributes.birthdate;
            data.email = request.Data.Attributes.email;
            data.phone_number = request.Data.Attributes.phone_number;
            data.update_at = DateTime.Now;
            _context.SaveChanges();

            
            return new GetCustomerDTO
            {
                Message = "Success retreiving data",
                Success = true,
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
