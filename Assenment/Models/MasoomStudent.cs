﻿using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class MasoomStudent
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Fname { get; set; } = null!;
        public string Email { get; set; } = null!;
        public long Mobile { get; set; }
    }
}
