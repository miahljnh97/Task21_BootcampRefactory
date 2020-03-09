using System;
using MediatR;

namespace MerchantService.Application.UseCases.MerchantMediator.Queries.GetMerchants
{
    public class GetMerchantsQuery : IRequest<GetMerchantsDTO>
    {
    }
}
