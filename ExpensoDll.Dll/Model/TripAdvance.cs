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
    
    public partial class TripAdvance
    {
        public int advanceId { get; set; }
        public string purchaseDesc { get; set; }
        public int tripLookUp_tripId { get; set; }
        public int personId_personId { get; set; }
        public int TripAdvance_advanceId { get; set; }
        public int enterdDate { get; set; }
        public int advanceAmount { get; set; }
        public string transactionId { get; set; }
    
        public virtual personId personId { get; set; }
        public virtual tripLookUp tripLookUp { get; set; }
    }
}
