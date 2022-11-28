using System;
using System.Collections.Generic;

namespace Gr9093coreApiEF.Models
{
    public partial class CustLog
    {
        public int Id { get; set; }
        public DateTime? LogDate { get; set; }
        public string? LogDescription { get; set; }
        public int? CustId { get; set; }
    }
}
