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
    
    public partial class BG_830PDFData_Result
    {
        public long PurchaseOrderID { get; set; }
        public long POItemID { get; set; }
        public string PartNumber { get; set; }
        public string GenericID { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string PoItemRefValue { get; set; }
        public string TransactionPurposeCode { get; set; }
        public string ForeCastType { get; set; }
        public string ScheduleQuantity { get; set; }
        public string RelaseNumber { get; set; }
        public Nullable<System.DateTime> ScheduleHorizonStartDate { get; set; }
        public Nullable<System.DateTime> ScheduleHorizonEndDate { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public string ShipTo { get; set; }
        public string ContactShipTo { get; set; }
        public string ShipToAddress { get; set; }
        public string ShipToContactInf { get; set; }
        public string BuyingParty { get; set; }
        public string BuyerQualifier { get; set; }
        public string BuyingParty2 { get; set; }
        public string BuyerQualifier2 { get; set; }
        public string SellingParty { get; set; }
        public string SellerContactInfo { get; set; }
        public string SellerQualifier { get; set; }
        public string ContactSeller { get; set; }
        public string SellerAddress { get; set; }
        public string FromTo { get; set; }
        public string Telephone { get; set; }
        public string unitDetail { get; set; }
        public string ShipDeliveryPattern { get; set; }
        public string ShipDeliveryPatternTim { get; set; }
        public string ResourceAutorization { get; set; }
        public Nullable<System.DateTime> ResourceTrougthDate { get; set; }
        public Nullable<int> CumulativeQuantity { get; set; }
        public string CumulativeQuantityStartDate { get; set; }
        public Nullable<int> DiscreteQuantity { get; set; }
        public Nullable<System.DateTime> ReceivedonThisDate { get; set; }
        public Nullable<int> HashTotal { get; set; }
    }
}
