using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class Febr
    {
        public Febr()
        {
            Febrrs = new HashSet<Febrr>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Febrr> Febrrs { get; set; }
    }
}
