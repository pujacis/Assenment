using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class SuyashRoleTable
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Roles { get; set; } = null!;

        public virtual SuyashLogInOfficeDatum User { get; set; } = null!;
    }
}
