using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Age { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public int Standard { get; set; }
    }
}
