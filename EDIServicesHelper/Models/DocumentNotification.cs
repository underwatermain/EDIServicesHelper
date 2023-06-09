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
    
    public partial class DocumentNotification
    {
        public int DocumentNotificationID { get; set; }
        public int MailNotificationID { get; set; }
        public string DocumentType { get; set; }
        public Nullable<int> SourceTP { get; set; }
        public Nullable<int> DestTP { get; set; }
        public bool Active { get; set; }
    
        public virtual TradingPartner TradingPartner { get; set; }
        public virtual DocumentType DocumentType1 { get; set; }
        public virtual MailNotification MailNotification { get; set; }
        public virtual TradingPartner TradingPartner1 { get; set; }
    }
}
