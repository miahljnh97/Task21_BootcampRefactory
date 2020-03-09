using System;
using MediatR;

namespace MerchantService.Application.UseCases.MerchantMediator.Queries.GetMerchant
{
    public class GetMerchantQuery : IRequest<GetMerchantDTO>
    {
        public int Id { get; set; }

        public GetMerchantQuery(int id)
        {
            Id = id;
        }
    }
}
