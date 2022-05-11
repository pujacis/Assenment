using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int DisplayOrder { get; set; }
        public DateTime CreatedDatTime { get; set; }
    }
}
