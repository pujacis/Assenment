using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class QnA
    {
        public QnA()
        {
            ExamResults = new HashSet<ExamResult>();
        }

        public int Id { get; set; }
        public int ExamsId { get; set; }
        public string Quenstion { get; set; } = null!;
        public int Answer { get; set; }
        public string Option1 { get; set; } = null!;
        public string Option2 { get; set; } = null!;
        public string Option3 { get; set; } = null!;
        public string Option4 { get; set; } = null!;

        public virtual Exam1 Exams { get; set; } = null!;
        public virtual ICollection<ExamResult> ExamResults { get; set; }
    }
}
