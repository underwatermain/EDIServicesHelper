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
    
    public partial class WOShipment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WOShipment()
        {
            this.WOReferenceIdentifications = new HashSet<WOReferenceIdentification>();
            this.WOShippingAdvices = new HashSet<WOShippingAdvice>();
            this.WOShipmentPackages = new HashSet<WOShipmentPackage>();
        }
    
        public long WOShipmentID { get; set; }
        public Nullable<long> WarehouseOrderID { get; set; }
        public int SourceTradingPartnerID { get; set; }
        public int DestinationTradingPartnerID { get; set; }
        public string TrackingNumber { get; set; }
        public string MethodOfPayment { get; set; }
        public string TransportationMethod { get; set; }
        public string CarrierName { get; set; }
        public string CarrierSCAC { get; set; }
        public Nullable<int> ShipToAddressID { get; set; }
        public Nullable<int> BillToAddressID { get; set; }
        public bool Active { get; set; }
    
        public virtual TradingPartner TradingPartner { get; set; }
        public virtual TradingPartner TradingPartner1 { get; set; }
        public virtual TradingPartnerAddress TradingPartnerAddress { get; set; }
        public virtual TradingPartnerAddress TradingPartnerAddress1 { get; set; }
        public virtual WarehouseOrder WarehouseOrder { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WOReferenceIdentification> WOReferenceIdentifications { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WOShippingAdvice> WOShippingAdvices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WOShipmentPackage> WOShipmentPackages { get; set; }
    }
}
