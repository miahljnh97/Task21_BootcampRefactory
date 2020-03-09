using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ProductService.Application.UseCases.ProductMediator.Commands;
using ProductService.Application.UseCases.ProductMediator.Request;
using ProductService.Model;

namespace Task18_BootcampRefactory.Application.UseCases.ProductMediator.Commands
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, ProductDTO>
    {
        private readonly PSContext _context;

        public DeleteProductCommandHandler(PSContext context)
        {
            _context = context;
        }

        public async Task<ProductDTO> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var data = await _context.products.FindAsync(request.Id);

            if (data == null)
            {
                return null;
            }

            _context.products.Remove(data);
            await _context.SaveChangesAsync();


            return new ProductDTO { Message = "Successfull", Success = true };

        }
    }
}
