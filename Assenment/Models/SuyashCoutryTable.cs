using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class SuyashCoutryTable
    {
        public SuyashCoutryTable()
        {
            SuyashStateTables = new HashSet<SuyashStateTable>();
        }

        public int Cid { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SuyashStateTable> SuyashStateTables { get; set; }
    }
}
