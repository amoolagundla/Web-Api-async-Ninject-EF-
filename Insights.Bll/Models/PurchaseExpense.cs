using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insights.Bll.Models
{
   public class PurchaseExpense
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

        public virtual personId personId { get; set; }
        public virtual purchaseDesc purchaseDesc1 { get; set; }
        public virtual tripLookUp tripLookUp { get; set; }
    }
}
