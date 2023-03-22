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
    
    public partial class BG_850PDFDataDropship_Result
    {
        public long PurchaseOrderID { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Number { get; set; }
        public Nullable<System.DateTime> PODate { get; set; }
        public string TypeCode { get; set; }
        public string ControlNumber { get; set; }
        public Nullable<int> IncludedSegmentsNo { get; set; }
        public string Message { get; set; }
        public string Message2 { get; set; }
        public Nullable<System.DateTime> RequestShip { get; set; }
        public Nullable<System.DateTime> CancelDate { get; set; }
        public Nullable<System.DateTime> PromisedDelivery { get; set; }
        public string ShipTo { get; set; }
        public string BuyerName { get; set; }
        public string ShipToAddress1 { get; set; }
        public string ShipToAddress2 { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToState { get; set; }
        public string ShipToPostal { get; set; }
        public string ShipToCountry { get; set; }
        public string StoreNumber { get; set; }
        public string BillToName { get; set; }
        public string BillToAddress1 { get; set; }
        public string BillToAddress2 { get; set; }
        public string BillToCity { get; set; }
        public string BillToState { get; set; }
        public string BillToPostal { get; set; }
        public string BillToCountry { get; set; }
        public string InternalVendorNumber { get; set; }
        public string InternalControlNumber { get; set; }
        public string CustomerOrderNumber { get; set; }
        public string SupplierNumber { get; set; }
        public string EndUsersPO { get; set; }
        public string LineItem { get; set; }
        public Nullable<long> QuantityOrdered { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Upc { get; set; }
        public string ItemNumber { get; set; }
        public string Unit { get; set; }
        public string ItemDescription { get; set; }
        public Nullable<decimal> GrossWeightPerPack { get; set; }
        public string GrossWeightUnit { get; set; }
        public Nullable<System.DateTime> POItemRequestedShipDate { get; set; }
        public Nullable<System.DateTime> POItemDeliveryRequestedDate { get; set; }
        public string GSVersion { get; set; }
        public string SCAC { get; set; }
        public string CarrierName { get; set; }
        public string ShipToContactName { get; set; }
        public string ShipToContactPhone { get; set; }
        public string ShipToContactEmail { get; set; }
        public string BillToContactName { get; set; }
        public string BillToContactPhone { get; set; }
        public string BillToContactEmail { get; set; }
    }
}
