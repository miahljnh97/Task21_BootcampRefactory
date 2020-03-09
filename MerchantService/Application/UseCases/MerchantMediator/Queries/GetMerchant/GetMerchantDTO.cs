using System;
using MerchantService.Model;

namespace MerchantService.Application.UseCases.MerchantMediator.Queries.GetMerchant
{
    public class GetMerchantDTO : BaseDTO
    {
        public MerchantData Data { get; set; }
    }

    public class MerchantData
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public double rating { get; set; }
    }
}
