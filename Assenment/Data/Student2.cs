using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class Student2
    {
        public Student2()
        {
            ExamResults = new HashSet<ExamResult>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Contact { get; set; } = null!;
        public string CvfileName { get; set; } = null!;
        public string PicturefileName { get; set; } = null!;
        public int GroupsId { get; set; }

        public virtual Group Groups { get; set; } = null!;
        public virtual ICollection<ExamResult> ExamResults { get; set; }
    }
}
