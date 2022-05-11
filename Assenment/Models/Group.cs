using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class Group
    {
        public Group()
        {
            Exam1s = new HashSet<Exam1>();
            Student2s = new HashSet<Student2>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int UsersId { get; set; }

        public virtual User1 Users { get; set; } = null!;
        public virtual ICollection<Exam1> Exam1s { get; set; }
        public virtual ICollection<Student2> Student2s { get; set; }
    }
}
