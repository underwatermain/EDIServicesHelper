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
    
    public partial class QuotationProvider
    {
        public int ProviderServiceAreaID { get; set; }
        public int QuotationServiceAreaID { get; set; }
        public decimal CostPerItem { get; set; }
        public decimal CostPerKG { get; set; }
        public Nullable<decimal> MarkupPerItem { get; set; }
        public Nullable<decimal> MarkupPerKG { get; set; }
        public Nullable<decimal> Revenue { get; set; }
    
        public virtual ProviderServiceArea ProviderServiceArea { get; set; }
        public virtual QuotationServiceArea QuotationServiceArea { get; set; }
    }
}