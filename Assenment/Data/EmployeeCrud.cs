using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class EmployeeCrud
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; } = null!;
        public string Position { get; set; } = null!;
        public string Office { get; set; } = null!;
        public int Age { get; set; }
        public int Salary { get; set; }
    }
}
