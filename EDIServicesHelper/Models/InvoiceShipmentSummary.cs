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
    
    public partial class InvoiceShipmentSummary
    {
        public long InvoiceShipmentSummaryID { get; set; }
        public Nullable<int> QuantityShipped { get; set; }
        public string Unit { get; set; }
        public Nullable<decimal> TotalShipmentWeight { get; set; }
        public string Unit2 { get; set; }
        public Nullable<long> InvoiceID { get; set; }
    
        public virtual Invoice Invoice { get; set; }
    }
}
