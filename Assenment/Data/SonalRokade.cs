using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class SonalRokade
    {
        public SonalRokade()
        {
            Details = new HashSet<Detail>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Mobile { get; set; } = null!;

        public virtual ICollection<Detail> Details { get; set; }
    }
}
