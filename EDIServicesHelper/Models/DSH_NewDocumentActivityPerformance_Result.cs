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
    
    public partial class DSH_NewDocumentActivityPerformance_Result
    {
        public Nullable<long> FileTransmissionID { get; set; }
        public string IsaControlNumber { get; set; }
        public Nullable<long> DocumentID { get; set; }
        public string FileName { get; set; }
        public Nullable<System.DateTime> ProcessedDate { get; set; }
        public Nullable<System.DateTime> ConfirmedDate { get; set; }
        public string DocumentTypeCode { get; set; }
        public string DocumentType { get; set; }
        public Nullable<int> SourceTP { get; set; }
        public Nullable<int> DestTP { get; set; }
        public string Source { get; set; }
        public string Dest { get; set; }
        public Nullable<bool> Succesful { get; set; }
        public string DocumentReference { get; set; }
        public string Status { get; set; }
        public Nullable<int> ClientID { get; set; }
        public Nullable<System.DateTime> SentDate { get; set; }
        public string MinLineItem { get; set; }
        public string MaxLineItem { get; set; }
        public Nullable<System.DateTime> ArchiveFileDate { get; set; }
    }
}
