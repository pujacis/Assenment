using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class Custmer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Contry { get; set; } = null!;
        public string City { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
    }
}
