using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class SuyashStateTable
    {
        public SuyashStateTable()
        {
            SuyashCityTables = new HashSet<SuyashCityTable>();
        }

        public int Sid { get; set; }
        public int Cid { get; set; }
        public string Name { get; set; } = null!;

        public virtual SuyashCoutryTable CidNavigation { get; set; } = null!;
        public virtual ICollection<SuyashCityTable> SuyashCityTables { get; set; }
    }
}
