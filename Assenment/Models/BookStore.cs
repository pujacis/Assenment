using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class BookStore
    {
        public int Bid { get; set; }
        public string BookTitle { get; set; } = null!;
        public string BookAuth { get; set; } = null!;
        public int Pages { get; set; }
    }
}
