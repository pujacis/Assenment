﻿using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class TblState
    {
        public int StateId { get; set; }
        public string? StateName { get; set; }
        public int? CountryId { get; set; }
    }
}
