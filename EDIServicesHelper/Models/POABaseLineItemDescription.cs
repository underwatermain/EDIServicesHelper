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
    
    public partial class POABaseLineItemDescription
    {
        public long POABaseLineItemDescriptionID { get; set; }
        public long POABaseLineItemID { get; set; }
        public string Type { get; set; }
        public string CharacteristicCode { get; set; }
        public string AgencyQualifierCode { get; set; }
        public string ProductDescriptionCode { get; set; }
        public string Description { get; set; }
    
        public virtual POABaseLineItem POABaseLineItem { get; set; }
    }
}
