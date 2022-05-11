using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class StudentRecord
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Age { get; set; } = null!;
        public string MobileNo { get; set; } = null!;
    }
}
