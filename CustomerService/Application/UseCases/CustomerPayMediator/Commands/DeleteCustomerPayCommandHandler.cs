using System;
using System.Threading;
using System.Threading.Tasks;
using CustomerService.Application.UseCases.CustomerPayMediator.Request;
using CustomerService.Model;
using MediatR;
namespace CustomerService.Application.UseCases.CustomerPayMediator.Commands
{
    public class DeleteCustomerPayCommandHandler : IRequestHandler<DeleteCustomerPayCommand, CustomerPayDTO>
    {
        private readonly CSContext _context;
        public DeleteCustomerPayCommandHandler(CSContext context)
        {
            _context = context;
        }

        public async Task<CustomerPayDTO> Handle(DeleteCustomerPayCommand request, CancellationToken cancellationToken)
        {
            var data = await _context.customerPayCard.FindAsync(request.Id);

            if (data == null)
            {
                return null;
            }

            _context.customerPayCard.Remove(data);
            await _context.SaveChangesAsync();

            
            return new CustomerPayDTO { Message = "Successfull", Success = true };

        }
    }
}
