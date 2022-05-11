using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class Department
    {
        public Department()
        {
            Emplos = new HashSet<Emplo>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Emplo> Emplos { get; set; }
    }
}
