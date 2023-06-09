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
    
    public partial class Document
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Document()
        {
            this.ActionHistories = new HashSet<ActionHistory>();
            this.DocumentElements = new HashSet<DocumentElement>();
            this.DocumentReferences = new HashSet<DocumentReference>();
        }
    
        public long DocumentID { get; set; }
        public int SourceTP { get; set; }
        public int DestTP { get; set; }
        public System.DateTime DocumentDate { get; set; }
        public long FileTransmissionID { get; set; }
        public Nullable<int> TransmissionChannelID { get; set; }
        public string OriginalFileName { get; set; }
        public string DocumentTypeCode { get; set; }
        public string DocumentContent { get; set; }
        public string DocumentReference { get; set; }
        public Nullable<int> BillableQuantity { get; set; }
        public Nullable<System.DateTime> ProcessingDate { get; set; }
        public Nullable<System.DateTime> ProcessedDate { get; set; }
        public string EdiTypeNumber { get; set; }
        public Nullable<long> ConfirmingDocumentID { get; set; }
        public string DocumentStatus { get; set; }
        public Nullable<long> GSNumber { get; set; }
        public Nullable<int> STNumber { get; set; }
        public string AdditionalReferences { get; set; }
        public Nullable<System.DateTime> ArchivedDate { get; set; }
        public string ISANumber { get; set; }
        public Nullable<int> ProcessingQueueID { get; set; }
        public string ReverseDocumentReference { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActionHistory> ActionHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentElement> DocumentElements { get; set; }
        public virtual TradingPartner TradingPartner { get; set; }
        public virtual FileTransmission FileTransmission { get; set; }
        public virtual TradingPartner TradingPartner1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentReference> DocumentReferences { get; set; }
    }
}
