using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class HariomBookTable
    {
        public string BookName { get; set; } = null!;
        public string Author { get; set; } = null!;
        public string Genre { get; set; } = null!;
        public int Price { get; set; }
        public int Discount { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int BookId { get; set; }
    }
}
