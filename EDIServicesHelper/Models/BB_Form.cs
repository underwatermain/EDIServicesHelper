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
    
    public partial class BB_Form
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BB_Form()
        {
            this.BB_FormField = new HashSet<BB_FormField>();
        }
    
        public int FormID { get; set; }
        public int QualediFileID { get; set; }
        public string Name { get; set; }
        public Nullable<int> TradingPartnerID { get; set; }
        public Nullable<System.DateTime> DeletedAt { get; set; }
        public Nullable<int> DestTP { get; set; }
    
        public virtual BB_QualediFile BB_QualediFile { get; set; }
        public virtual TradingPartner TradingPartner { get; set; }
        public virtual TradingPartner TradingPartner1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BB_FormField> BB_FormField { get; set; }
    }
}