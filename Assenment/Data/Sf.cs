using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class Sf
    {
        public int Id { get; set; }
        public int StateId { get; set; }
        public string Name { get; set; } = null!;

        public virtual Abc State { get; set; } = null!;
    }
}
