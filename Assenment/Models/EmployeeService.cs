using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class EmployeeService
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Designation { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? ContactNumber { get; set; }
    }
}
