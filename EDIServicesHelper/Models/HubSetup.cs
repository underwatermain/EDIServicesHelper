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
    
    public partial class HubSetup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HubSetup()
        {
            this.HubSetupSteps = new HashSet<HubSetupStep>();
        }
    
        public byte HubSetupID { get; set; }
        public int HubID { get; set; }
        public string SetupName { get; set; }
        public string SetupDescription { get; set; }
    
        public virtual Hub Hub { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HubSetupStep> HubSetupSteps { get; set; }
    }
}
