using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ProductService.Model;

namespace ProductService.Application.UseCases.ProductMediator.Queries.GetProduct
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, GetProductDTO>
    {
        private readonly PSContext _context;

        public GetProductQueryHandler(PSContext context)
        {
            _context = context;
        }

        public async Task<GetProductDTO> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var data = await _context.products.FindAsync(request.Id);

            if (data == null)
            {
                return null;
            }
            else
            {
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
}
