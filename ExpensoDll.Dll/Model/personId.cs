//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExpensoDll.Dll.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class personId
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public personId()
        {
            this.individualPurchases = new HashSet<individualPurchas>();
            this.purchaseExpenses = new HashSet<purchaseExpens>();
            this.TripAdvances = new HashSet<TripAdvance>();
            this.tripGroups = new HashSet<tripGroup>();
        }
    
        public int personId1 { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailId { get; set; }
        public long phoneNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<individualPurchas> individualPurchases { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<purchaseExpens> purchaseExpenses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TripAdvance> TripAdvances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tripGroup> tripGroups { get; set; }
    }
}
