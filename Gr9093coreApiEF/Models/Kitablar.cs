using System;
using System.Collections.Generic;

namespace Gr9093coreApiEF.Models
{
    public partial class Kitablar
    {
        public int Id { get; set; }
        public string? KitabAd { get; set; }
        public string? KitabYazar { get; set; }
        public int? KitabSehife { get; set; }
        public decimal? KitabQiymet { get; set; }
        public DateTime? KitabTarix { get; set; }
        public string? KitabCapev { get; set; }
    }
}
