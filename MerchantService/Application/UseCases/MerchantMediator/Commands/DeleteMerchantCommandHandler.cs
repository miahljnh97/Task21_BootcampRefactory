using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MerchantService.Application.UseCases.MerchantMediator.Commands;
using MerchantService.Application.UseCases.MerchantMediator.Request;
using MerchantService.Model;

namespace MerchantService.Application.UseCases.MerchantMediator.Commands
{
    public class DeleteMerchantCommandHandler : IRequestHandler<DeleteMerchantCommand, MerchantDTO>
    {
        private readonly MSContext _context;
        public DeleteMerchantCommandHandler(MSContext context)
        {
            _context = context;
        }

        public async Task<MerchantDTO> Handle(DeleteMerchantCommand request, CancellationToken cancellationToken)
        {
            var data = await _context.merchants.FindAsync(request.Id);

            if (data == null)
            {
                return null;
            }

            _context.merchants.Remove(data);
            await _context.SaveChangesAsync();

            return new MerchantDTO { Message = "Successfull", Success = true };

        }
    }
}
