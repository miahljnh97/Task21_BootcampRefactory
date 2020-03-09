using System;
using System.Collections.Generic;
using CustomerService.Application.UseCases.CustomerMediator.Queries.GetCustomer;
using CustomerService.Model;

namespace CustomerService.Application.UseCases.CustomerMediator.Queries.GetCustomers
{
    public class GetCustomersDTO : BaseDTO
    {
        public List<CustomerData> Data { get; set; }
    }
}
