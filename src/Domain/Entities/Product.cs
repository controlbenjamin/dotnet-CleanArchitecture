using System;
using System.Collections.Generic;
using System.Text;

namespace sample_ca.Domain.Entities
{
    public class Product
    {

        public int Id { get; set; }

        public string Description { get; set; }

        public int Stock { get; set; } 

        public DateTime? LastModified { get; set; }

    }
}
