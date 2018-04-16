using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tranactionsDB
{
    // ID int
    // Timestamp DateTime
    // Action nvarchar
    // AccountNumber nvarchar
    // AmountChanged decimal
    // NewAmount decimal

    public class Transactions
    {
        public int ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Action { get; set; }
        public string AccountNumber { get; set; }
        public decimal AmountChanged { get; set; }
        public decimal NewAmount { get; set; }
    }
}
