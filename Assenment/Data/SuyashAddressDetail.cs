using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class SuyashAddressDetail
    {
        public SuyashAddressDetail()
        {
            SuyashEmployeeDetails = new HashSet<SuyashEmployeeDetail>();
        }

        public int Id { get; set; }
        public string Details { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Country { get; set; } = null!;

        public virtual ICollection<SuyashEmployeeDetail> SuyashEmployeeDetails { get; set; }
    }
}
