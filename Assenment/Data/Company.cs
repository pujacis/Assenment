using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class Company
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = null!;
        public string EmployeeDesignation { get; set; } = null!;
        public string EmployeeSalary { get; set; } = null!;
        public string EmployeeSkills { get; set; } = null!;
    }
}
