using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class SuyashSchoolRecord
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Position { get; set; } = null!;
        public int Salary { get; set; }
    }
}
