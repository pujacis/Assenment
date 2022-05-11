using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class ManishSignUp
    {
        public int Id { get; set; }
        public string EmailId { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string ConfirmPasssword { get; set; } = null!;
    }
}
