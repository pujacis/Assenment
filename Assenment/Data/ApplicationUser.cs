using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class ApplicationUser
    {
        public ApplicationUser()
        {
            Roles = new HashSet<ApplicationRole>();
        }

        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public string NormalizedUserName { get; set; } = null!;
        public string? Email { get; set; }
        public string? NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string? PasswordHash { get; set; }
        public string? PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }

        public virtual ICollection<ApplicationRole> Roles { get; set; }
    }
}
