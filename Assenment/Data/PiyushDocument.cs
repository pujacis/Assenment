using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class PiyushDocument
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public string Name { get; set; } = null!;
        public string Path { get; set; } = null!;
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }

        public virtual PiyushProject Project { get; set; } = null!;
    }
}
