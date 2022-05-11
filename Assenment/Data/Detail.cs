using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class Detail
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Branch { get; set; } = null!;
        public string College { get; set; } = null!;
        public int? SrId { get; set; }

        public virtual SonalRokade? Sr { get; set; }
    }
}
