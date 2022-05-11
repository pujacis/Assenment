using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class User
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public string Email { get; set; } = null!;
        public DateTime? CreateOn { get; set; }
    }
}
