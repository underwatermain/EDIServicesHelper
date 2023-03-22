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
    
    public partial class Utils_GetPOAndASNInfo_Result
    {
        public long PurchaseOrderID { get; set; }
        public int HubID { get; set; }
        public int TradingPartnerID { get; set; }
        public string TransactionSetPurposeCode { get; set; }
        public string TypeCode { get; set; }
        public string Number { get; set; }
        public string RelaseNumber { get; set; }
        public System.DateTime Date { get; set; }
        public string EntityIdentifierCode { get; set; }
        public string CurrencyCode { get; set; }
        public string ContactFunctionCode { get; set; }
        public string Name { get; set; }
        public string CommunicationNumberQualifier1 { get; set; }
        public string CommunicationNumber1 { get; set; }
        public string CommunicationNumberQualifier2 { get; set; }
        public string CommunicationNumber2 { get; set; }
        public string CommunicationNumberQualifier3 { get; set; }
        public string CommunicationNumber3 { get; set; }
        public string ContactInquiryReference { get; set; }
        public string PurchaseOrderStatusCode { get; set; }
        public bool Active { get; set; }
        public Nullable<System.DateTime> ShipDate { get; set; }
        public Nullable<System.DateTime> CancelDate { get; set; }
        public Nullable<decimal> POAmount { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public System.DateTime CreationDateTime { get; set; }
        public Nullable<System.DateTime> PODate { get; set; }
        public Nullable<long> FileTransmissionID { get; set; }
        public Nullable<bool> IsMultistore { get; set; }
        public string TransactionSetControlNumber { get; set; }
        public Nullable<int> IncludedSegmentsNo { get; set; }
        public Nullable<System.DateTime> NotDeliverAfter { get; set; }
        public Nullable<System.DateTime> NotDeliverBefore { get; set; }
        public string Message { get; set; }
        public string WeightUnit { get; set; }
        public string WeightPO { get; set; }
        public string VolumePO { get; set; }
        public string ContractNumber { get; set; }
        public Nullable<System.DateTime> LastResetDateTime { get; set; }
        public string RevisionNumber { get; set; }
        public Nullable<System.DateTime> RevisionDate { get; set; }
        public Nullable<int> Version { get; set; }
        public string SecurityLevelCode { get; set; }
        public Nullable<System.DateTime> DeliveryRequested { get; set; }
        public Nullable<System.DateTime> ShipNoLater { get; set; }
        public Nullable<int> BookingID { get; set; }
        public Nullable<System.DateTime> CreationDateBooking { get; set; }
    }
}
