﻿using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class NishidEmployee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? Designation { get; set; }
        public string? City { get; set; }
        public int? Salary { get; set; }
    }
}
