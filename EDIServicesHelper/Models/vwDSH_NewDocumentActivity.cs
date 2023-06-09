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
    
    public partial class vwDSH_NewDocumentActivity
    {
        public long FileTransmissionID { get; set; }
        public string IsaControlNumber { get; set; }
        public long DocumentID { get; set; }
        public System.DateTime DocumentDate { get; set; }
        public string FileName { get; set; }
        public Nullable<System.DateTime> ProcessedDate { get; set; }
        public Nullable<System.DateTime> ConfirmedDate { get; set; }
        public string EdiTypeNumber { get; set; }
        public string ftDocumentTypeCode { get; set; }
        public string DocumentTypeCode { get; set; }
        public string DocumentType { get; set; }
        public Nullable<int> SourceTP { get; set; }
        public Nullable<int> DestTP { get; set; }
        public int docSourceTP { get; set; }
        public int docDestTP { get; set; }
        public string Source { get; set; }
        public bool Succesful { get; set; }
        public string DocumentReference { get; set; }
        public string ReverseDocumentReference { get; set; }
        public string AdditionalReferences { get; set; }
        public string Status { get; set; }
        public Nullable<int> ClientID { get; set; }
        public Nullable<System.DateTime> SentDate { get; set; }
        public Nullable<System.DateTime> docArchivedDate { get; set; }
        public Nullable<System.DateTime> ArchiveFileDate { get; set; }
        public int tpSourceTradingPartnerID { get; set; }
        public Nullable<int> tpSourceParentTradingPartnerID { get; set; }
        public Nullable<long> cnt { get; set; }
    }
}
