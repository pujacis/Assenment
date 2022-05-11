using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class Todo
    {
        public int TodoId { get; set; }
        public string Description { get; set; } = null!;
        public bool Complete { get; set; }
        public int UserId { get; set; }

        public virtual Userrr User { get; set; } = null!;
    }
}
