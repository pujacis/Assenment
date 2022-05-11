using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class ManishDropDownList
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public int? Quantity { get; set; }
        public string? Color { get; set; }
        public decimal? Price { get; set; }
        public string? ProductCode { get; set; }
    }
}
