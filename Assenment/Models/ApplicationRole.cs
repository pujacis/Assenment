using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class ApplicationRole
    {
        public ApplicationRole()
        {
            Users = new HashSet<ApplicationUser>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string NormalizedName { get; set; } = null!;

        public virtual ICollection<ApplicationUser> Users { get; set; }
    }
}
