using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class Result
    {
        public int SlNo { get; set; }
        public int CandidateId { get; set; }
        public int ExamId { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
        public int SelectedOptionId { get; set; }
        public bool IsCorrent { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string? SessionId { get; set; }
    }
}
