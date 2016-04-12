using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insights.Dll.Model
{
    public class PurchaseExpenseDao
    {
        public int pExpenseId { get; set; }
        public int tripLookUp_tripId { get; set; }
        public int personId_personId { get; set; }
        public int purchaseDesc_descId { get; set; }
        public int purchaseAmount { get; set; }
        public string purcahsedesc { get; set; }
        public System.DateTime enteredDate { get; set; }
        public string transactionId { get; set; }
        public string purchasedesc { get; set; }
    }
}
