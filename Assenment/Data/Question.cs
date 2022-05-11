using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class Question
    {
        public int QuestionId { get; set; }
        public int QuestionType { get; set; }
        public string? DisplayText { get; set; }
        public int ExamId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
