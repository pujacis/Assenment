using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class Card
    {
        public Guid Id { get; set; }
        public string CardholderName { get; set; } = null!;
        public string CardNumber { get; set; } = null!;
        public int ExpiryMonth { get; set; }
        public int ExpiryYear { get; set; }
        public int Cvc { get; set; }
    }
}
