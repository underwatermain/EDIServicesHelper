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
    
    public partial class WOShipmentPackage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WOShipmentPackage()
        {
            this.LabelCartonNumbers = new HashSet<LabelCartonNumber>();
            this.WOShipmentItems = new HashSet<WOShipmentItem>();
        }
    
        public long WOShipmentPackageID { get; set; }
        public long WOShipmentID { get; set; }
        public Nullable<short> PackageTypeID { get; set; }
        public string CartonNumber { get; set; }
        public string PackagingSpecificationNumber { get; set; }
        public Nullable<int> SequentialNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LabelCartonNumber> LabelCartonNumbers { get; set; }
        public virtual PackageType PackageType { get; set; }
        public virtual WOShipment WOShipment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WOShipmentItem> WOShipmentItems { get; set; }
    }
}
