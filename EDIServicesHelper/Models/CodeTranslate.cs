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
    
    public partial class CodeTranslate
    {
        public long CodeTranslateID { get; set; }
        public int Hub { get; set; }
        public int TradingPartner { get; set; }
        public string HubCode { get; set; }
        public string TradingPartnerCode { get; set; }
        public string ApplicationReceiverCode { get; set; }
        public string ApplicationSenderCode { get; set; }
        public string SenderIDQualifier { get; set; }
        public string ReceiverIDQualifier { get; set; }
        public Nullable<bool> Active { get; set; }
        public string TestIndicator { get; set; }
    
        public virtual TradingPartner TradingPartner1 { get; set; }
        public virtual Hub Hub1 { get; set; }
    }
}
