using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class SuyashEmployeeDetail
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int AddressId { get; set; }
        public string Code { get; set; } = null!;

        public virtual SuyashAddressDetail Address { get; set; } = null!;
    }
}
