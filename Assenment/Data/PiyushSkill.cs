using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class PiyushSkill
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Skill { get; set; } = null!;
        public string Proficiancy { get; set; } = null!;
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }

        public virtual PiyushUser User { get; set; } = null!;
    }
}
