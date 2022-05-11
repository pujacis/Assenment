using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public string? Remarks { get; set; }
    }
}
