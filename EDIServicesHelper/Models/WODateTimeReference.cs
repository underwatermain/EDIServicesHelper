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
    
    public partial class WODateTimeReference
    {
        public long WODateTimeReferenceID { get; set; }
        public long WarehouseOrderID { get; set; }
        public string Qualifier { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual WarehouseOrder WarehouseOrder { get; set; }
    }
}
