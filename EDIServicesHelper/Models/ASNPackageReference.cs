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
    
    public partial class ASNPackageReference
    {
        public long ASNPackageReferenceID { get; set; }
        public long ASNPackageID { get; set; }
        public string Qualifier { get; set; }
        public string Value { get; set; }
    
        public virtual ASNPackage ASNPackage { get; set; }
    }
}
