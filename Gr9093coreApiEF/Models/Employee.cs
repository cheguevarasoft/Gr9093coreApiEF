using System;
using System.Collections.Generic;

namespace Gr9093coreApiEF.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Paswword { get; set; }
        public decimal? Mobile { get; set; }
        public int? Identityno { get; set; }
        public string? Identitypin { get; set; }
        public DateTime? Birthdate { get; set; }
        public string? Birthplace { get; set; }
    }
}
