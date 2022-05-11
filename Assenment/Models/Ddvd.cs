using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class Ddvd
    {
        public Ddvd()
        {
            Abcs = new HashSet<Abc>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Abc> Abcs { get; set; }
    }
}
