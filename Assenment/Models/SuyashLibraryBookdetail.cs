using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class SuyashLibraryBookdetail
    {
        public int Id { get; set; }
        public string BookName { get; set; } = null!;
        public string Author { get; set; } = null!;
        public string Genre { get; set; } = null!;
        public string ReleaseDate { get; set; } = null!;
        public int Price { get; set; }
        public int Discount { get; set; }
    }
}
