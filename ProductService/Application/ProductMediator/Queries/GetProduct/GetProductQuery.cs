using System;
using MediatR;

namespace ProductService.Application.UseCases.ProductMediator.Queries.GetProduct
{
    public class GetProductQuery : IRequest<GetProductDTO>
    {
        public int Id { get; set; }

        public GetProductQuery(int id)
        {
            Id = id;
        }
    }
}
