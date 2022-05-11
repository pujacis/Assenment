using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class SuyashCityTable
    {
        public int CtyId { get; set; }
        public int Sid { get; set; }
        public string Name { get; set; } = null!;

        public virtual SuyashStateTable SidNavigation { get; set; } = null!;
    }
}
