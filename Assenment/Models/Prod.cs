using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class Prod
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string? Remarks { get; set; }
    }
}
