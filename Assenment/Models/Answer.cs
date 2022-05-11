using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class Answer
    {
        public int SlNo { get; set; }
        public int QuestionId { get; set; }
        public int ChoiceId { get; set; }
        public string? DisplayText { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
