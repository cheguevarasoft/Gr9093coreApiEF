using System;
using System.Collections.Generic;

namespace Gr9093coreApiEF.Models
{
    public partial class Sale
    {
        public int TranId { get; set; }
        public int? SalesCount { get; set; }
        public int? PrId { get; set; }
    }
}
