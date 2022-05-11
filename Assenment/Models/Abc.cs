using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class Abc
    {
        public Abc()
        {
            Sfs = new HashSet<Sf>();
        }

        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; } = null!;

        public virtual Ddvd Country { get; set; } = null!;
        public virtual ICollection<Sf> Sfs { get; set; }
    }
}
