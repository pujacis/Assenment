using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class City
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int LastUpdatedby { get; set; }
        public DateTime LastUpdatedon { get; set; }
        public string? Country { get; set; }
    }
}
