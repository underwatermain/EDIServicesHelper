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
    
    public partial class ECW_Variation
    {
        public int VariationID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public string VariationSKU { get; set; }
        public Nullable<System.DateTime> InsertedDate { get; set; }
        public Nullable<System.DateTime> LastUpdateQuantity { get; set; }
    
        public virtual ECW_Product ECW_Product { get; set; }
    }
}
