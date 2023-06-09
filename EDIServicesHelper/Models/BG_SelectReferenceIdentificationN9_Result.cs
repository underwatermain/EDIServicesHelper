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
    
    public partial class BG_SelectReferenceIdentificationN9_Result
    {
        public long WarehouseOrderID { get; set; }
        public int HubID { get; set; }
        public int TradingPartnerID { get; set; }
        public string TransactionSetPurposeCode { get; set; }
        public string TypeCode { get; set; }
        public string Number { get; set; }
        public string DepositorOrderNumber { get; set; }
        public string LinkSequenceNumber { get; set; }
        public string MasterReferenceLinkNo { get; set; }
        public System.DateTime Date { get; set; }
        public string EntityIdentifierCode { get; set; }
        public string CurrencyCode { get; set; }
        public string ContactFunctionCode { get; set; }
        public string Name { get; set; }
        public string CommunicationNumber1 { get; set; }
        public string CommunicationNumberQualifier1 { get; set; }
        public string CommunicationNumberQualifier2 { get; set; }
        public string CommunicationNumber2 { get; set; }
        public string CommunicationNumberQualifier3 { get; set; }
        public string CommunicationNumber3 { get; set; }
        public string ContactInquiryReference { get; set; }
        public string OrderStatusCode { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<System.DateTime> EarliestShipDate { get; set; }
        public Nullable<System.DateTime> LatestShipDate { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public System.DateTime CreationDateTime { get; set; }
        public Nullable<System.DateTime> PODate { get; set; }
        public Nullable<long> FileTransmission { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<System.DateTime> CancelDate { get; set; }
        public Nullable<System.DateTime> ExpectedDeliveryDate { get; set; }
        public Nullable<long> SecuencialTripNumber { get; set; }
        public Nullable<long> PurchaseOrderID { get; set; }
        public long RefernceIdentificationID { get; set; }
        public string CustomerNumber { get; set; }
        public long WarehouseOrderID1 { get; set; }
        public string WarehouseLocation { get; set; }
        public string SupplierNumber { get; set; }
        public string PurchaseOrderSuffix { get; set; }
        public string DespartmentNumber { get; set; }
        public string MasterCarton { get; set; }
        public Nullable<long> WOShipmentID { get; set; }
    }
}
