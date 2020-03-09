using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MerchantService.Application.UseCases.MerchantMediator.Queries.GetMerchant;
using MerchantService.Model;

namespace MerchantService.Application.UseCases.MerchantMediator.Queries.GetMerchant
{
    public class GetMerchantQueryHandler : IRequestHandler<GetMerchantQuery, GetMerchantDTO>
    {
        private readonly MSContext _context;

        public GetMerchantQueryHandler(MSContext context)
        {
            _context = context;
        }

        public async Task<GetMerchantDTO> Handle(GetMerchantQuery request, CancellationToken cancellationToken)
        {
            var data = await _context.merchants.FindAsync(request.Id);

            if (data == null)
            {
                return null;
            }
            else
            {
                return new GetMerchantDTO
                {
                    Success = true,
                    Message = "Success retreiving data",
                    Data = new MerchantData
                    {
                        Id = data.Id,
                        name = data.name,
                        image = data.image,
                        email = data.email,
                        address = data.address,
                        rating = data.rating
                    }
                };
            }
        }
    }
}
 