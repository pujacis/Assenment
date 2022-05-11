using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class ManishOrder
    {
        public int OrderId { get; set; }
        public string? OrderNo { get; set; }
        public int? CustomerId { get; set; }
        public string? Pmethod { get; set; }
        public decimal? Gtotal { get; set; }
    }
}
