using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class Exam
    {
        public int ExamId { get; set; }
        public string? Name { get; set; }
        public decimal FullMarks { get; set; }
        public decimal Duration { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
