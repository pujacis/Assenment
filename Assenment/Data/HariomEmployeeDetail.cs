using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class HariomEmployeeDetail
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime JoiningDate { get; set; }
        public decimal SalaryPerMonth { get; set; }
        public decimal AnnualSalary { get; set; }
        public decimal PfDeduction { get; set; }
        public string Address { get; set; } = null!;

        public virtual HariomEmployee? Employee { get; set; }
    }
}
