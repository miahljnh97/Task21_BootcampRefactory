using System;
using MediatR;
using MerchantService.Application.UseCases.MerchantMediator.Queries.GetMerchant;
using MerchantService.Model;

namespace MerchantService.Application.UseCases.MerchantMediator.Commands
{
    public class PostMerchantCommand : CommandDTO<Merchant>, IRequest<GetMerchantDTO>
    {
        
    }
}
