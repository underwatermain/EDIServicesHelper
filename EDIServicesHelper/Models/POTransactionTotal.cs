//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EDIServicesHelper.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class POTransactionTotal
    {
        public long POTransactionTotalsID { get; set; }
        public long PurchaseOrderID { get; set; }
        public Nullable<long> NumberLineItems { get; set; }
        public Nullable<long> HashTotal { get; set; }
        public Nullable<long> Weight { get; set; }
        public string UnitCode { get; set; }
        public Nullable<long> Volume { get; set; }
        public string UnitCode2 { get; set; }
        public string Description { get; set; }
    
        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}
