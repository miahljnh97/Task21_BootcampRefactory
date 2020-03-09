using System;
using System.Collections.Generic;
using ProductService.Application.UseCases.ProductMediator.Queries.GetProduct;
using ProductService.Model;

namespace ProductService.Application.UseCases.ProductMediator.Queries.GetProducts
{
    public class GetProductsDTO : BaseDTO
    {
        public List<ProductData> Data { get; set; }
    }
}
