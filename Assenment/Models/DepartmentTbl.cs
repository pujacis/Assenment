using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class DepartmentTbl
    {
        public DepartmentTbl()
        {
            EmployeeTbls = new HashSet<EmployeeTbl>();
        }

        public string DeptId { get; set; } = null!;
        public string DeptName { get; set; } = null!;
        public string DeptLocation { get; set; } = null!;

        public virtual ICollection<EmployeeTbl> EmployeeTbls { get; set; }
    }
}
