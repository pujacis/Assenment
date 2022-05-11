using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class SuyashPracticeDatum
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; } = null!;
        public string EmpDesignation { get; set; } = null!;
        public decimal? EmpPhoneNumber { get; set; }
    }
}
