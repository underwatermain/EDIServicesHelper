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
    
    public partial class TurnAroundElement
    {
        public int TurnAroundDocumentID { get; set; }
        public string InputElement { get; set; }
        public string OutputElement { get; set; }
        public string ConditionalElement { get; set; }
        public string ConditionalValue { get; set; }
        public int MasterTradingPartner { get; set; }
        public int SlaveTradingPartner { get; set; }
    }
}
