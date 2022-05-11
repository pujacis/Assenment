using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class Exam1
    {
        public Exam1()
        {
            ExamResults = new HashSet<ExamResult>();
            QnAs = new HashSet<QnA>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public int Time { get; set; }
        public int GroupsId { get; set; }

        public virtual Group Groups { get; set; } = null!;
        public virtual ICollection<ExamResult> ExamResults { get; set; }
        public virtual ICollection<QnA> QnAs { get; set; }
    }
}
