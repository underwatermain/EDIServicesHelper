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
    
    public partial class POExtendedReferenceInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public POExtendedReferenceInfo()
        {
            this.POReferenceTexts = new HashSet<POReferenceText>();
        }
    
        public long POExtendedReferenceInfoID { get; set; }
        public long PurchaseOrderID { get; set; }
        public string ReferenceIdQualifier { get; set; }
        public string ReferenceId { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string MessageText { get; set; }
    
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POReferenceText> POReferenceTexts { get; set; }
    }
}
