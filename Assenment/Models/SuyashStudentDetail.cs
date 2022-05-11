using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class SuyashStudentDetail
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int RollNumber { get; set; }
        public string Subject { get; set; } = null!;
        public string Class { get; set; } = null!;
    }
}
