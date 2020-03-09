using System;
using System.Collections.Generic;
using MerchantService.Application.UseCases.MerchantMediator.Queries.GetMerchant;
using MerchantService.Model;

namespace MerchantService.Application.UseCases.MerchantMediator.Queries.GetMerchants
{
    public class GetMerchantsDTO : BaseDTO
    {
        public List<MerchantData> Data { get; set; }
    }
}
