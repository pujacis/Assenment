using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class Candidate
    {
        public int SlNo { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? CandidateId { get; set; }
        public string? Password { get; set; }
        public string? ImgFile { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string? Roles { get; set; }
    }
}
