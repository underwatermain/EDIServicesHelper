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
    
    public partial class InvoiceAddressReference
    {
        public long InvoiceAddressReferenceID { get; set; }
        public string IdentificationQualifier { get; set; }
        public string Value { get; set; }
        public Nullable<long> InvoiceAddressID { get; set; }
    
        public virtual InvoiceAddress InvoiceAddress { get; set; }
    }
}