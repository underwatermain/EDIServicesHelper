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
    
    public partial class PartnershipDocumentChannel
    {
        public int MasterTradingPartnerID { get; set; }
        public int SlaveTradingPartnerID { get; set; }
        public int TradingPartnerDocumentTypeID { get; set; }
        public int ChannelID { get; set; }
    
        public virtual Channel Channel { get; set; }
        public virtual TradingPartner TradingPartner { get; set; }
        public virtual TradingPartner TradingPartner1 { get; set; }
        public virtual TradingPartnerDocumentType TradingPartnerDocumentType { get; set; }
    }
}
