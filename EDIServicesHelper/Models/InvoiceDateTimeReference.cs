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
    
    public partial class InvoiceDateTimeReference
    {
        public long InvoiceDateTimeReferenceID { get; set; }
        public string DateTimeReferenceQualifier { get; set; }
        public Nullable<System.DateTime> DateTimeReferenceDate { get; set; }
        public Nullable<long> InvoiceID { get; set; }
    
        public virtual Invoice Invoice { get; set; }
    }
}
