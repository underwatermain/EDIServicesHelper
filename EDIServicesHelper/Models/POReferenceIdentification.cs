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
    
    public partial class POReferenceIdentification
    {
        public long POReferenceIdentificationID { get; set; }
        public long PurchaseOrderID { get; set; }
        public string Qualifier { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
    
        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}