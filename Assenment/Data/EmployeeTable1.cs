using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class EmployeeTable1
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public int Age { get; set; }
        public string Email { get; set; } = null!;
    }
}
