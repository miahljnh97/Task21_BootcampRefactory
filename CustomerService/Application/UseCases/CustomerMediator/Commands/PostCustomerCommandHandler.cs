﻿using System;
using System.Threading;
using System.Threading.Tasks;
using CustomerService.Application.UseCases.CustomerMediator.Queries.GetCustomer;
using CustomerService.Model;
using MediatR;

namespace CustomerService.Application.UseCases.CustomerMediator.Commands
{
    public class PostCustomerCommandHandler : IRequestHandler<PostCustomerCommand, GetCustomerDTO>
    {
        private readonly CSContext _context;

        public PostCustomerCommandHandler(CSContext context)
        {
            _context = context;
        }

        public async Task<GetCustomerDTO> Handle(PostCustomerCommand request, CancellationToken cancellationToken)
        {
            if (request.Data.Attributes.gender == "male")
            {
                request.Data.Attributes.sex = Gender.male;
            }
            else if (request.Data.Attributes.gender == "female")
            {
                request.Data.Attributes.sex = Gender.female;
            }
            _context.customers.Add(request.Data.Attributes);
            await _context.SaveChangesAsync();

            
            return new GetCustomerDTO
            {
                Message = "Successfully Added",
                Success = true,
                Data = new CustomerData
                {
                    Id = request.Data.Attributes.Id,
                    Full_name = request.Data.Attributes.full_name,
                    Username = request.Data.Attributes.username,
                    Birthdate = request.Data.Attributes.birthdate,
                    Password = request.Data.Attributes.password,
                    Gender = Enum.GetName(typeof(Gender), request.Data.Attributes.sex),
                    Email = request.Data.Attributes.email,
                    Phone_number = request.Data.Attributes.phone_number
                }
            };
        }
    }
}
