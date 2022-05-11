using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class HariomEmployee
    {
        public HariomEmployee()
        {
            HariomEmployeeDetails = new HashSet<HariomEmployeeDetail>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNo { get; set; } = null!;

        public virtual ICollection<HariomEmployeeDetail> HariomEmployeeDetails { get; set; }
    }
}
