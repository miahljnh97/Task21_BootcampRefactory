using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MerchantService.Application.UseCases.MerchantMediator.Queries.GetMerchant;
using MerchantService.Model;

namespace MerchantService.Application.UseCases.MerchantMediator.Commands
{
    public class PutMerchantCommandHandler : IRequestHandler<PutMerchantCommand, GetMerchantDTO>
    {

        private readonly MSContext _context;

        public PutMerchantCommandHandler(MSContext context)
        {
            _context = context;
        }

        public async Task<GetMerchantDTO> Handle(PutMerchantCommand request, CancellationToken cancellationToken)
        {
            var data = await _context.merchants.FindAsync(request.Data.Attributes.Id);

            data.name = request.Data.Attributes.name;
            data.image = request.Data.Attributes.image;
            data.email = request.Data.Attributes.email;
            data.address = request.Data.Attributes.address;
            data.rating = request.Data.Attributes.rating;

            _context.SaveChanges();

            
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
