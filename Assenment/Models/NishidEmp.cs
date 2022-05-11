using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class NishidEmp
    {
        public int CustomerId { get; set; }
        public string CustName { get; set; } = null!;
        public string? Email { get; set; }
        public string? Address { get; set; }
    }
}
