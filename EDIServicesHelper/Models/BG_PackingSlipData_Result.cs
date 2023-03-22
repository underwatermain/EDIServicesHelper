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
    
    public partial class BG_PackingSlipData_Result
    {
        public long WarehouseOrderID { get; set; }
        public string TPName { get; set; }
        public string OrderNumber { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public int TradingPartnerID { get; set; }
        public int HubID { get; set; }
        public string TripNumber { get; set; }
        public string Department { get; set; }
        public string ShipFrom { get; set; }
        public string ShipFromAddress { get; set; }
        public string ShipFromCity { get; set; }
        public string ShipFromState { get; set; }
        public string ShipfromPostalCode { get; set; }
        public string CustomerName { get; set; }
        public string Store { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string TranID { get; set; }
        public string Service { get; set; }
        public long WOShipmentItemID { get; set; }
        public string ItemNumber { get; set; }
        public string UPCNumber { get; set; }
        public string Pack { get; set; }
        public Nullable<long> Quantity { get; set; }
        public string Description { get; set; }
        public Nullable<int> QuantityStore { get; set; }
        public string ShipToNumber { get; set; }
        public string HdrUser3 { get; set; }
        public string LineUser2 { get; set; }
        public string CartonID { get; set; }
    }
}