using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class MasoomBook
    {
        public int BookId { get; set; }
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public int Price { get; set; }
    }
}
