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
    
    public partial class RoutingRequestShipmentInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RoutingRequestShipmentInfo()
        {
            this.RRShipmentInfoAddresses = new HashSet<RRShipmentInfoAddress>();
            this.RRShipmentInfoDateTimes = new HashSet<RRShipmentInfoDateTime>();
            this.RRShipmentInfoOrderDetails = new HashSet<RRShipmentInfoOrderDetail>();
        }
    
        public long RoutingRequestShipmentInfoID { get; set; }
        public long RoutingRequestID { get; set; }
        public string BusinessReference { get; set; }
        public string BusinessDescription { get; set; }
        public int Quantity { get; set; }
        public string QuantityCode { get; set; }
        public Nullable<bool> ConditionResponse { get; set; }
    
        public virtual RoutingRequest RoutingRequest { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RRShipmentInfoAddress> RRShipmentInfoAddresses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RRShipmentInfoDateTime> RRShipmentInfoDateTimes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RRShipmentInfoOrderDetail> RRShipmentInfoOrderDetails { get; set; }
    }
}
