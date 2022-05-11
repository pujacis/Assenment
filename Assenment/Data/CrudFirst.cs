using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class CrudFirst
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Fname { get; set; } = null!;
        public string Email { get; set; } = null!;
        public long Mobile { get; set; }
        public string? Description { get; set; }
    }
}
