﻿using System;
using ProductService.Model;

namespace ProductService.Application.UseCases.ProductMediator.Queries.GetProduct
{
    public class GetProductDTO : BaseDTO
    {
        public ProductData Data { get; set; }
    }

    public class ProductData
    {
        public int Id { get; set; }
        public int merchant_id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
    }
}
