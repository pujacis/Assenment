using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class TblPersonAddr
    {
        public TblPersonAddr()
        {
            TblPeople = new HashSet<TblPerson>();
        }

        public int Id { get; set; }
        public string? Details { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }

        public virtual ICollection<TblPerson> TblPeople { get; set; }
    }
}
