using System;
using MediatR;
using ProductService.Application.UseCases.ProductMediator.Queries.GetProduct;
using ProductService.Model;

namespace ProductService.Application.UseCases.ProductMediator.Commands
{
    public class PostProductCommand : CommandDTO<Products>, IRequest<GetProductDTO>
    {
       
    }
}
