﻿using System;
using System.Collections.Generic;

namespace Gr9093coreApiEF.Models
{
    public partial class Registration
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Gender { get; set; }
    }
}
