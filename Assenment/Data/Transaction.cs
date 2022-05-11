using System;
using System.Collections.Generic;

namespace Assenment.data
{
    public partial class Transaction
    {
        public int TransactionId { get; set; }
        public string AccountNumber { get; set; } = null!;
        public string BankName { get; set; } = null!;
        public string BeneficiaryId { get; set; } = null!;
        public string SwiftCode { get; set; } = null!;
        public int Amount { get; set; }
        public DateTime Date { get; set; }
        public string GenderId { get; set; } = null!;
    }
}
