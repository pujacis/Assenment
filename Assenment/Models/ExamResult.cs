using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class ExamResult
    {
        public int Id { get; set; }
        public int StudentsId { get; set; }
        public int ExamsId { get; set; }
        public int QnAsId { get; set; }
        public int Answer { get; set; }
        public string Title { get; set; } = null!;

        public virtual Exam1 Exams { get; set; } = null!;
        public virtual QnA QnAs { get; set; } = null!;
        public virtual Student2 Students { get; set; } = null!;
    }
}
