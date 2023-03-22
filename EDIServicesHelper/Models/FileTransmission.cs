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
    
    public partial class FileTransmission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FileTransmission()
        {
            this.ASNShipments = new HashSet<ASNShipment>();
            this.CarrierShipments = new HashSet<CarrierShipment>();
            this.CarrierShipments1 = new HashSet<CarrierShipment>();
            this.Documents = new HashSet<Document>();
            this.IncomingDocumentDetails = new HashSet<IncomingDocumentDetail>();
            this.POAcknowledgments = new HashSet<POAcknowledgment>();
            this.PurchaseOrders = new HashSet<PurchaseOrder>();
            this.WOShippingAdvices = new HashSet<WOShippingAdvice>();
            this.WarehouseOrders = new HashSet<WarehouseOrder>();
            this.IncomingDocuments = new HashSet<IncomingDocument>();
            this.Invoices = new HashSet<Invoice>();
            this.Messages = new HashSet<Message>();
            this.POALineItemAcknowledgments = new HashSet<POALineItemAcknowledgment>();
            this.RoutingRequests = new HashSet<RoutingRequest>();
            this.TextMessages = new HashSet<TextMessage>();
        }
    
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
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASNShipment> ASNShipments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarrierShipment> CarrierShipments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarrierShipment> CarrierShipments1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Document> Documents { get; set; }
        public virtual DocumentType DocumentType { get; set; }
        public virtual TradingPartner TradingPartner { get; set; }
        public virtual Hub Hub { get; set; }
        public virtual TradingPartner TradingPartner1 { get; set; }
        public virtual TradingPartner TradingPartner2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IncomingDocumentDetail> IncomingDocumentDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POAcknowledgment> POAcknowledgments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WOShippingAdvice> WOShippingAdvices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WarehouseOrder> WarehouseOrders { get; set; }
        public virtual TransmissionChannel TransmissionChannel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IncomingDocument> IncomingDocuments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message> Messages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POALineItemAcknowledgment> POALineItemAcknowledgments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoutingRequest> RoutingRequests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TextMessage> TextMessages { get; set; }
    }
}
