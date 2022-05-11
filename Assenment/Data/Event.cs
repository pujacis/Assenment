﻿using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class Event
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string? Text { get; set; }
        public string? Color { get; set; }
    }
}
