using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class BookGallery
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }

        public virtual Book Book { get; set; } = null!;
    }
}
