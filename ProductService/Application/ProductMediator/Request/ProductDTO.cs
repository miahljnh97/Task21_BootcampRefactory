using System;
using System.Collections.Generic;
using ProductService.Application.UseCases.ProductMediator.Queries.GetProduct;
using ProductService.Model;

namespace ProductService.Application.UseCases.ProductMediator.Request
{
    public class ProductDTO : BaseDTO
    {
        List<ProductData> Data { get; set; }
    }
}
