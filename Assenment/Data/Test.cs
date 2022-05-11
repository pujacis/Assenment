using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class Test
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Experience { get; set; } = null!;
        public string Company { get; set; } = null!;
        public string? Designation { get; set; }
    }
}
