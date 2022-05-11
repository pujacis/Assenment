using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class SonalStudent
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Fname { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Mobile { get; set; } = null!;
        public int DepId { get; set; }
    }
}
