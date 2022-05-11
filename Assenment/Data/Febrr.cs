using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class Febrr
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; } = null!;
        public string Designation { get; set; } = null!;

        public virtual Febr Department { get; set; } = null!;
    }
}
