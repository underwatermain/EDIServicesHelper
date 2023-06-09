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
    
    public partial class POCarrierDetail
    {
        public long POCarrierDetailID { get; set; }
        public long PurchaseOrderID { get; set; }
        public string RoutingSequenceCode { get; set; }
        public string IdentificationCodeQualifier { get; set; }
        public string IdentificationCode { get; set; }
        public string TransportationMethodCode { get; set; }
        public string Routing { get; set; }
        public string ShipmentOrderStatusCode { get; set; }
        public string LocationQualifier { get; set; }
        public string LocationIdentifier { get; set; }
        public string TransitDirectionCode { get; set; }
        public string TransitTimeQualifier { get; set; }
        public string TransitTime { get; set; }
        public string ServiceLevelCode1 { get; set; }
        public string ServiceLevelCode2 { get; set; }
        public string ServiceLevelCode3 { get; set; }
        public string CountryCode { get; set; }
        public string HazmatHandling { get; set; }
        public string HazmatDescription { get; set; }
    
        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}
