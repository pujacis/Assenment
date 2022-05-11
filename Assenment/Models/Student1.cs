using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class Student1
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Mobile { get; set; } = null!;
        public string? Address { get; set; }
    }
}
