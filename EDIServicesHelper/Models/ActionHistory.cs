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
    
    public partial class ActionHistory
    {
        public long ActionHistoryID { get; set; }
        public long DocumentActionID { get; set; }
        public long DocumentID { get; set; }
        public Nullable<int> TransmissionChannelID { get; set; }
        public System.DateTime ProcessingDate { get; set; }
        public Nullable<System.DateTime> ProcessedDate { get; set; }
        public Nullable<bool> Successful { get; set; }
        public string Message { get; set; }
    
        public virtual Document Document { get; set; }
        public virtual DocumentAction DocumentAction { get; set; }
        public virtual TransmissionChannel TransmissionChannel { get; set; }
    }
}
