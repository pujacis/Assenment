using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class SchoolStd
    {
        public int StdId { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public string Gender { get; set; } = null!;
        public string Course { get; set; } = null!;
    }
}
