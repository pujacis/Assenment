using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public long Mobile { get; set; }
        public string? Company { get; set; }
        public string? Title { get; set; }
        public int GroupId { get; set; }
    }
}
