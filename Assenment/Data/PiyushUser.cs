using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class PiyushUser
    {
        public PiyushUser()
        {
            PiyushDailyStatuses = new HashSet<PiyushDailyStatus>();
            PiyushProjects = new HashSet<PiyushProject>();
            PiyushSkills = new HashSet<PiyushSkill>();
            PiyushToDoWorks = new HashSet<PiyushToDoWork>();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime? JoiningDate { get; set; }
        public DateTime? Dob { get; set; }
        public string? Address { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? Username { get; set; }
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }

        public virtual ICollection<PiyushDailyStatus> PiyushDailyStatuses { get; set; }
        public virtual ICollection<PiyushProject> PiyushProjects { get; set; }
        public virtual ICollection<PiyushSkill> PiyushSkills { get; set; }
        public virtual ICollection<PiyushToDoWork> PiyushToDoWorks { get; set; }
    }
}
