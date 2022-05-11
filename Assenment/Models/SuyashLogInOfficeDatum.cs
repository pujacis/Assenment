using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class SuyashLogInOfficeDatum
    {
        public SuyashLogInOfficeDatum()
        {
            SuyashRoleTables = new HashSet<SuyashRoleTable>();
        }

        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual ICollection<SuyashRoleTable> SuyashRoleTables { get; set; }
    }
}
