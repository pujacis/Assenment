using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class Address
    {
        public int Id { get; set; }
        public string StreetName { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zipcode { get; set; } = null!;
        public int? PersonId { get; set; }

        public virtual Person? Person { get; set; }
    }
}
