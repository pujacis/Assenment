using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class Operation
    {
        public int EmpId { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public string Gender { get; set; } = null!;
        public byte[] Email { get; set; } = null!;
        public int Salary { get; set; }
    }
}
