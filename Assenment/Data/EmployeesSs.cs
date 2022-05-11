using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class EmployeesSs
    {
        public int Id { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public long Phone { get; set; }
        public string Email { get; set; } = null!;
        public string Companyname { get; set; } = null!;
    }
}
