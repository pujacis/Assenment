using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class SuyashEmpDetail
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int PhoneNumber { get; set; }
        public int? GenderId { get; set; }
    }
}
