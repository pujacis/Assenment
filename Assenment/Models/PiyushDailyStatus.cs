using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class PiyushDailyStatus
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }

        public virtual PiyushUser User { get; set; } = null!;
    }
}
