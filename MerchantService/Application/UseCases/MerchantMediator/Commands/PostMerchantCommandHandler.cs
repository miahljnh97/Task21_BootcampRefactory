using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MerchantService.Application.UseCases.MerchantMediator.Queries.GetMerchant;
using MerchantService.Model;

namespace MerchantService.Application.UseCases.MerchantMediator.Commands
{
    public class PostMerchantCommandHandler : IRequestHandler<PostMerchantCommand, GetMerchantDTO>
    {
        private readonly MSContext _context;
        public PostMerchantCommandHandler(MSContext context)
        {
            _context = context;
        }

        public async Task<GetMerchantDTO> Handle(PostMerchantCommand request, CancellationToken cancellationToken)
        {
            _context.merchants.Add(request.Data.Attributes);
            await _context.SaveChangesAsync();

            
            return new GetMerchantDTO
            {
                Message = "Success retreiving data",
                Success = true,
                Data = new MerchantData
                {
                    Id = request.Data.Attributes.Id,
                    name = request.Data.Attributes.name,
                    image = request.Data.Attributes.image,
                    email = request.Data.Attributes.email,
                    address = request.Data.Attributes.address,
                    rating = request.Data.Attributes.rating
                }
            };
        }
    }
}
