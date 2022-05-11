using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class Qualification
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Degree { get; set; } = null!;
        public int PassOutYear { get; set; }
    }
}
