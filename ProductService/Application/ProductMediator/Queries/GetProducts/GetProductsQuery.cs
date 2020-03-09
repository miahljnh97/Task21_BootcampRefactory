using System;
using MediatR;

namespace ProductService.Application.UseCases.ProductMediator.Queries.GetProducts
{
    public class GetProductsQuery : IRequest<GetProductsDTO>
    {
        public GetProductsQuery()
        {
        }
    }
}
