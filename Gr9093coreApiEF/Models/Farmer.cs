using System;
using System.Collections.Generic;

namespace Gr9093coreApiEF.Models
{
    public partial class Farmer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Mutexessis { get; set; }
        public string? Baytar { get; set; }
        public bool? Smmstatus { get; set; }
        public bool? Baytarstatus { get; set; }
    }
}
