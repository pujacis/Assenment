using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class Vaccine
    {
        public int Id { get; set; }
        public string StateName { get; set; } = null!;
        public int NoOfVaccinationCentre { get; set; }
        public int Population { get; set; }
        public string Status { get; set; } = null!;
    }
}
