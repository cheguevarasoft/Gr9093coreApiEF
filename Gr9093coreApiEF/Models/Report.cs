using System;
using System.Collections.Generic;

namespace Gr9093coreApiEF.Models
{
    public partial class Report
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Description { get; set; }
    }
}
