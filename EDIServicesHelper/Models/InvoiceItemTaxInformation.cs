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
    
    public partial class InvoiceItemTaxInformation
    {
        public long InvoiceItemTaxInformationID { get; set; }
        public string TaxTypeCode { get; set; }
        public Nullable<decimal> TaxAmount { get; set; }
        public Nullable<decimal> TaxPercent { get; set; }
        public Nullable<long> InvoiceItemID { get; set; }
        public string IndicatorCode { get; set; }
    
        public virtual InvoiceItem InvoiceItem { get; set; }
    }
}
