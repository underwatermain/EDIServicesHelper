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
    
    public partial class BG_850PDFData_Result
    {
        public long PurchaseOrderID { get; set; }
        public string POStatus { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Number { get; set; }
        public Nullable<System.DateTime> PODate { get; set; }
        public Nullable<decimal> POAmount { get; set; }
        public string TypeCode { get; set; }
        public string TransactionSetPurposeCode { get; set; }
        public string Code { get; set; }
        public Nullable<System.DateTime> NotDeliverBefore { get; set; }
        public string Version { get; set; }
        public string Message { get; set; }
        public string Message2 { get; set; }
        public Nullable<System.DateTime> RequestShip { get; set; }
        public Nullable<System.DateTime> CancelDate { get; set; }
        public Nullable<System.DateTime> DeliveryRequest { get; set; }
        public Nullable<System.DateTime> ShipNotBefore { get; set; }
        public string BuyerName { get; set; }
        public string BuyerAddress { get; set; }
        public string BuyerPostalCode { get; set; }
        public string BuyerCity { get; set; }
        public string BuyerState { get; set; }
        public string StoreNumber { get; set; }
        public string InternalVendorNumber { get; set; }
        public string VendorCode { get; set; }
        public Nullable<long> QuantityOrdered { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> RetailPrice { get; set; }
        public string LineItem { get; set; }
        public string Upc { get; set; }
        public string VendorsStyleNumber { get; set; }
        public string VendorsItemNumber { get; set; }
        public string Unit { get; set; }
        public Nullable<long> Pack { get; set; }
        public string ItemDescription { get; set; }
        public Nullable<System.DateTime> ItemDeliveryDate { get; set; }
        public string MethodOfPayment { get; set; }
        public string DepartmentNumber { get; set; }
    }
}
