using System;
using System.Collections.Generic;

namespace Assenment.Models
{
    public partial class AjaxCrud
    {
        public int TransactionId { get; set; }
        public string AccountNumber { get; set; } = null!;
        public string BeneficiaryName { get; set; } = null!;
        public string BankName { get; set; } = null!;
        public string Swiftcode { get; set; } = null!;
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
