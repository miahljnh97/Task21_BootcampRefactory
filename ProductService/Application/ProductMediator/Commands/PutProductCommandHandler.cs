using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ProductService.Application.UseCases.ProductMediator.Commands;
using ProductService.Application.UseCases.ProductMediator.Queries.GetProduct;
using ProductService.Model;

namespace Task18_BootcampRefactory.Application.UseCases.ProductMediator.Commands
{
    public class PutProductCommandHandler : IRequestHandler<PutProductCommand, GetProductDTO>
    {
        private readonly PSContext _context;

        public PutProductCommandHandler(PSContext context)
        {
            _context = context;
        }

        public async Task<GetProductDTO> Handle(PutProductCommand request, CancellationToken cancellationToken)
        {
            var data = await _context.products.FindAsync(request.Data.Attributes.Id);

            data.name = request.Data.Attributes.name;
            data.merchant_id = request.Data.Attributes.merchant_id;
            data.price = request.Data.Attributes.price;

            _context.SaveChanges();

            return new GetProductDTO
            {
                Success = true,
                Message = "Success retreiving data",
                Data = new ProductData
                {
                    Id = data.Id,
                    name = data.name,
                    merchant_id = data.merchant_id,
                    price = data.price

                }
            };
        }
    }
}
