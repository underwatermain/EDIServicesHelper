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
    
    public partial class Utils_ShowRecentTransmissionsStatus_Result
    {
        public long FileTransmissionID { get; set; }
        public string FileName { get; set; }
        public string DocumentTypeCode { get; set; }
        public string FileContents { get; set; }
        public string ErrorMessage { get; set; }
        public bool Succesful { get; set; }
        public Nullable<System.DateTime> ProcessedDate { get; set; }
        public Nullable<int> HubID { get; set; }
        public Nullable<int> TradingPartnerID { get; set; }
        public Nullable<int> SourceTP { get; set; }
        public Nullable<int> DestTP { get; set; }
        public Nullable<int> TransmissionChannelID { get; set; }
        public Nullable<System.DateTime> ConfirmedDate { get; set; }
        public Nullable<long> ControlNumber { get; set; }
        public string Status { get; set; }
        public Nullable<long> ConfirmingFT { get; set; }
        public Nullable<System.DateTime> SentDate { get; set; }
        public Nullable<long> PartnershipControlNumber { get; set; }
        public Nullable<long> PartnershipGroupNumber { get; set; }
        public Nullable<int> ProcessingQueueID { get; set; }
        public Nullable<int> DocsInFT { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ProcessingDate { get; set; }
    }
}