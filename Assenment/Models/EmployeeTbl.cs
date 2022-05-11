using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class EmployeeTbl
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; } = null!;
        public int EmpSalary { get; set; }
        public string? DeptId { get; set; }

        public virtual DepartmentTbl? Dept { get; set; }
    }
}
