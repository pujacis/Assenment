using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class TblPerson
    {
        public int EmployeeId { get; set; }
        public string? Name { get; set; }
        public int? Address { get; set; }
        public string? Designation { get; set; }
        public decimal? Salary { get; set; }
        public DateTime? JoiningDate { get; set; }

        public virtual TblPersonAddr? AddressNavigation { get; set; }
    }
}
