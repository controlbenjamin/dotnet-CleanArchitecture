using System;
using System.Collections.Generic;
using System.Text;

namespace sample_ca.Application.Products.Queries.GetProducts
{
    public class ProductsVm
    {
        public IList<ProductDto> Products { get; set; }

        public ProductDto Product { get; set; }

    }
}
