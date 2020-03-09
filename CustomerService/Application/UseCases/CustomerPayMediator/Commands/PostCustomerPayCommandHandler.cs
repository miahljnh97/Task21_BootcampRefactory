﻿using System;
using System.Threading;
using System.Threading.Tasks;
using CustomerService.Application.UseCases.CustomerPayMediator.Queries.GetCustomerPayDTO;
using CustomerService.Model;
using MediatR;
namespace CustomerService.Application.UseCases.CustomerPayMediator.Commands
{
    public class PostCustomerPayCommandHandler : IRequestHandler<PostCustomerPayCommand, GetCustomerPayDTO>
    {
        private readonly CSContext _context;
        public PostCustomerPayCommandHandler(CSContext context)
        {
            _context = context;
        }

        public async Task<GetCustomerPayDTO> Handle(PostCustomerPayCommand request, CancellationToken cancellationToken)
        {
            _context.customerPayCard.Add(request.Data.Attributes);
            await _context.SaveChangesAsync();
             
            return new GetCustomerPayDTO
            {
                Message = "Success retreiving data",
                Success = true,
                Data = new CustomerPayData
                {
                    Id = request.Data.Attributes.Id,
                    Customer_id = request.Data.Attributes.customer_id,
                    Name_on_card = request.Data.Attributes.name_on_card,
                    Exp_month = request.Data.Attributes.exp_month,
                    Exp_year = request.Data.Attributes.exp_year,
                    Postal_code = request.Data.Attributes.postal_code,
                    Credit_card_number = request.Data.Attributes.credit_card_number
                }
            };
        }
    }
}
