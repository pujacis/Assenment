using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class User1
    {
        public User1()
        {
            Groups = new HashSet<Group>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int Role { get; set; }

        public virtual ICollection<Group> Groups { get; set; }
    }
}
