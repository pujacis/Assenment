using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class Userrr
    {
        public Userrr()
        {
            Todos = new HashSet<Todo>();
        }

        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual ICollection<Todo> Todos { get; set; }
    }
}
