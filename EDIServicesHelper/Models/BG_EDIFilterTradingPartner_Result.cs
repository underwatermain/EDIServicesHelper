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
    
    public partial class BG_EDIFilterTradingPartner_Result
    {
        public long EDIFilterTradingPartnerID { get; set; }
        public long SourceTP { get; set; }
        public long DestTP { get; set; }
        public string DocumentType { get; set; }
        public bool Active { get; set; }
        public bool DeleteInSource { get; set; }
    }
}
