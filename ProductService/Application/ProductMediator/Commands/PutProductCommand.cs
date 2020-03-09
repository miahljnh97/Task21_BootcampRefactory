using System;
using MediatR;
using ProductService.Application.UseCases.ProductMediator.Queries.GetProduct;
using ProductService.Model;

namespace ProductService.Application.UseCases.ProductMediator.Commands
{
    public class PutProductCommand : CommandDTO<Products>, IRequest<GetProductDTO>
    {
    }
}
