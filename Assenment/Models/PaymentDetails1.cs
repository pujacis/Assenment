using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class PaymentDetails1
    {
        public int PaymentDetailId { get; set; }
        public string CardOwnerName { get; set; } = null!;
        public string CardNumber { get; set; } = null!;
        public string ExpirationDate { get; set; } = null!;
        public string SecurityCode { get; set; } = null!;
    }
}
