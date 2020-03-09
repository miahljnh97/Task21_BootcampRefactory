using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ProductService.Application.UseCases.ProductMediator.Commands;
using ProductService.Application.UseCases.ProductMediator.Queries.GetProduct;
using ProductService.Model;

namespace Task18_BootcampRefactory.Application.UseCases.ProductMediator.Commands
{
    public class PostProductCommandHandler : IRequestHandler<PostProductCommand, GetProductDTO>
    {
        private readonly PSContext _context;

        public PostProductCommandHandler(PSContext context)
        {
            _context = context;
        }

        public async Task<GetProductDTO> Handle(PostProductCommand request, CancellationToken cancellationToken)
        {
            _context.products.Add(request.Data.Attributes);
            await _context.SaveChangesAsync();

            return new GetProductDTO
            {
                Message = "Success retreiving data",
                Success = true,
                Data = new ProductData
                {
                    Id = request.Data.Attributes.Id,
                    name = request.Data.Attributes.name,
                    merchant_id = request.Data.Attributes.merchant_id,
                    price = request.Data.Attributes.price
                }
            };
        }
    }
}
