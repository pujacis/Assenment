using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class HotelSystem
    {
        public int CustId { get; set; }
        public string CustName { get; set; } = null!;
        public int Roomno { get; set; }
        public string Status { get; set; } = null!;
    }
}
