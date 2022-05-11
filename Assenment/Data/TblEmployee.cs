using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class TblEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public int Age { get; set; }
        public string Designation { get; set; } = null!;
        public int Salary { get; set; }
    }
}
