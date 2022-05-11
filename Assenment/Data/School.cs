using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class School
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public int Mobnumber { get; set; }
        public string Email { get; set; } = null!;
    }
}
