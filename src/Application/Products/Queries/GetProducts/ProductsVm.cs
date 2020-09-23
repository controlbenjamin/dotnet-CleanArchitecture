using System;
using System.Collections.Generic;
using System.Text;

namespace sample_ca.Application.Products.Queries.GetProducts
{
    public class ProductsVm
    {
        public IEnumerable<ProductDto> Products { get; set; }

        public ProductDto Product { get; set; }

    }
}
