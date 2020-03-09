using System;
using System.Threading;
using System.Threading.Tasks;
using CustomerService.Application.UseCases.CustomerMediator.Request;
using CustomerService.Model;
using MediatR;

namespace CustomerService.Application.UseCases.CustomerMediator.Commands
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand, CustomerDTO>
    {
        private readonly CSContext _context;
        public DeleteCustomerCommandHandler(CSContext context)
        {
            _context = context;
        }

        public async Task<CustomerDTO> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            var data = await _context.customers.FindAsync(request.Id);

            if (data == null)
            {
                return null;
            }

            _context.customers.Remove(data);
            await _context.SaveChangesAsync();

            return new CustomerDTO { Message = "Successfull", Success = true };

        }
    }
}
