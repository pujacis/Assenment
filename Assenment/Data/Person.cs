using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class Person
    {
        public Person()
        {
            Addresses = new HashSet<Address>();
            EmailAddresses = new HashSet<EmailAddress>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int Age { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<EmailAddress> EmailAddresses { get; set; }
    }
}
