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
    
    public partial class POItemSpecification
    {
        public long POItemSpeficicationID { get; set; }
        public long POItemID { get; set; }
        public string SecurityLevelCode { get; set; }
        public string ReferenceIdentificationQualifier { get; set; }
        public string ReferenceIdentification { get; set; }
        public string EntityTitle { get; set; }
    
        public virtual POItem POItem { get; set; }
    }
}
