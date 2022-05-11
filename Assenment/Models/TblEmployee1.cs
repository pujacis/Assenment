using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class TblEmployee1
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public int Age { get; set; }
        public DateTime Doj { get; set; }
        public string? Gender { get; set; }
        public int IsMarried { get; set; }
        public int IsActive { get; set; }
        public int DesignationId { get; set; }
    }
}
