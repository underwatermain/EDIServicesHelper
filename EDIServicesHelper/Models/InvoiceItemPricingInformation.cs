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
    
    public partial class InvoiceItemPricingInformation
    {
        public long InvoiceItemPricingInformationID { get; set; }
        public string PriceQuialifier { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public string PriceMultiplierQualifier { get; set; }
        public Nullable<decimal> DiscountMultiplier { get; set; }
        public Nullable<long> InvoiceItemID { get; set; }
    
        public virtual InvoiceItem InvoiceItem { get; set; }
    }
}