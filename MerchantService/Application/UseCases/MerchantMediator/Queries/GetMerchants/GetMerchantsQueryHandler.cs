using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MerchantService.Application.UseCases.MerchantMediator.Queries.GetMerchant;
using MerchantService.Model;

namespace MerchantService.Application.UseCases.MerchantMediator.Queries.GetMerchants
{
    public class GetMerchantsQueryHandler : IRequestHandler<GetMerchantsQuery, GetMerchantsDTO>
    {
        private readonly MSContext _context;

        public GetMerchantsQueryHandler(MSContext context)
        {
            _context = context;
        }

        public async Task<GetMerchantsDTO> Handle(GetMerchantsQuery request, CancellationToken cancellationToken)
        {
            var data = await _context.merchants.ToListAsync();
            var result = new List<MerchantData>();

            foreach (var x in data)
            {
                result.Add(new MerchantData
                {
                    Id = x.Id,
                    name = x.name,
                    image = x.image,
                    email = x.email,
                    address = x.address,
                    rating = x.rating
                });
            }

            return new GetMerchantsDTO
            {
                Success = true,
                Message = "Success retreiving data",
                Data = result
            };
        }
    }
}
