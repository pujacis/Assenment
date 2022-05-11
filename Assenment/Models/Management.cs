using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class Management
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public int Age { get; set; }
        public string Position { get; set; } = null!;
        public string Dept { get; set; } = null!;
        public int Salary { get; set; }
    }
}
