using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class SuyashNew
    {
        public int Id { get; set; }
        public string FName { get; set; } = null!;
        public string LName { get; set; } = null!;
        public string Designation { get; set; } = null!;
        public decimal Salary { get; set; }
        public string? City { get; set; }
        public string Village { get; set; } = null!;
    }
}
