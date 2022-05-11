using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class ManishProduct
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = null!;
        public int TotalQuantity { get; set; }
    }
}
