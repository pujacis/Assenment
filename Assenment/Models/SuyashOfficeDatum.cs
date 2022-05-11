using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class SuyashOfficeDatum
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Designation { get; set; } = null!;
        public int Salary { get; set; }
    }
}
