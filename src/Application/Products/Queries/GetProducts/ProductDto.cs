using System;
using System.Collections.Generic;
using System.Text;

namespace sample_ca.Application.Products.Queries.GetProducts
{
    public class ProductDto
    {

        public int Id { get; set; }

        public string Description { get; set; }

        public int Stock { get; set; }

        public DateTime? LastModified { get; set; }
    }
}
