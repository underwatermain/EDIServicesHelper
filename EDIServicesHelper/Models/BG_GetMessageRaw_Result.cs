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
    
    public partial class BG_GetMessageRaw_Result
    {
        public long MessageID { get; set; }
        public string DocumentTypeCode { get; set; }
        public Nullable<int> SourceTP { get; set; }
        public Nullable<int> DestTP { get; set; }
        public Nullable<int> ChannelID { get; set; }
        public string MessageText { get; set; }
        public Nullable<System.DateTime> MessageDateTime { get; set; }
        public Nullable<System.DateTime> Processed { get; set; }
        public Nullable<long> PurchaseOrderID { get; set; }
        public Nullable<long> WarehouseOrderID { get; set; }
        public Nullable<long> FileTransmission { get; set; }
        public Nullable<System.DateTime> Processing { get; set; }
    }
}
