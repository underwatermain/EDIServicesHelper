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
    
    public partial class ASNCarrierDetailRouting
    {
        public long CarrierDetailsRoutingID { get; set; }
        public long AdvanceShipNoticeID { get; set; }
        public string RoutingCode { get; set; }
        public string CodeQualifier { get; set; }
        public string Code { get; set; }
        public string TransportMethodCode { get; set; }
        public string Routing { get; set; }
        public string StatusCode { get; set; }
        public Nullable<int> NumberIdShipmentLevel { get; set; }
    
        public virtual ASNShipment ASNShipment { get; set; }
    }
}
