using System;
using System.Collections.Generic;
using CustomerService.Application.UseCases.CustomerPayMediator.Queries.GetCustomerPayDTO;
using CustomerService.Model;

namespace CustomerService.Application.UseCases.CustomerPayMediator.Queries.GetCustomersPaysDTO
{
    public class GetCustomerPaysDTO : BaseDTO
    {
        public List<CustomerPayData> Data { get; set; }
    }
}
