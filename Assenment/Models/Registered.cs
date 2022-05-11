using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class Registered
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Contact { get; set; }
        public string? Address { get; set; }
    }
}
