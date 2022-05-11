using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class Language
    {
        public Language()
        {
            Books = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
