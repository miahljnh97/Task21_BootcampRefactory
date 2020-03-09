using System;
using MediatR;
using ProductService.Application.UseCases.ProductMediator.Request;

namespace ProductService.Application.UseCases.ProductMediator.Commands
{
    public class DeleteProductCommand : IRequest<ProductDTO>
    {
        public int Id { get; set; }

        public DeleteProductCommand(int id)
        {
            Id = id;
        }
    }
}
