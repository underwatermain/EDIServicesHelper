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
    
    public partial class Hub
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hub()
        {
            this.CarrierShipments = new HashSet<CarrierShipment>();
            this.CodeTranslates = new HashSet<CodeTranslate>();
            this.FileTransmissions = new HashSet<FileTransmission>();
            this.HubSetups = new HashSet<HubSetup>();
            this.HubSpecifications = new HashSet<HubSpecification>();
            this.HubTradingPartners = new HashSet<HubTradingPartner>();
            this.HubContacts = new HashSet<HubContact>();
            this.HubEDISegments = new HashSet<HubEDISegment>();
        }
    
        public int HubID { get; set; }
        public int TradingPartnerID { get; set; }
        public string CurrencyCode { get; set; }
        public Nullable<bool> OverwriteExistingPO { get; set; }
        public Nullable<bool> ConsiderSmallParcel { get; set; }
        public Nullable<bool> SumItemSACs { get; set; }
        public Nullable<bool> Ecommerce { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarrierShipment> CarrierShipments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CodeTranslate> CodeTranslates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FileTransmission> FileTransmissions { get; set; }
        public virtual TradingPartner TradingPartner { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HubSetup> HubSetups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HubSpecification> HubSpecifications { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HubTradingPartner> HubTradingPartners { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HubContact> HubContacts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HubEDISegment> HubEDISegments { get; set; }
    }
}
