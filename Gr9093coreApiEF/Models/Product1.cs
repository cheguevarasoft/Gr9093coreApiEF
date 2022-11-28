using System;
using System.Collections.Generic;

namespace Gr9093coreApiEF.Models
{
    public partial class Product1
    {
        public int Id { get; set; }
        public string? PrName { get; set; }
        public decimal? PrPrice { get; set; }
        public int? PrStock { get; set; }
    }
}
