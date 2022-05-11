using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class PaymentDetail
    {
        public int MyProperty { get; set; }
        public string? CardOwnerName { get; set; }
        public string? CardNumber { get; set; }
        public string? ExpirationDate { get; set; }
        public string? SecurityCode { get; set; }
    }
}
