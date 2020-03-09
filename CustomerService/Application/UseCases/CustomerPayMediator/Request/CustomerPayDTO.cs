using System;
using System.Collections.Generic;
using CustomerService.Application.UseCases.CustomerPayMediator.Queries.GetCustomerPayDTO;
using CustomerService.Model;

namespace CustomerService.Application.UseCases.CustomerPayMediator.Request
{
    public class CustomerPayDTO : BaseDTO
    {
        public List<CustomerPayData> Data { get; set; }
    }
}
