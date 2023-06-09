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
    
    public partial class BG_850S2KData_Result
    {
        public long PurchaseOrderID { get; set; }
        public string Number { get; set; }
        public Nullable<System.DateTime> PODate { get; set; }
        public Nullable<decimal> POAmount { get; set; }
        public string BuyerName { get; set; }
        public string AdditionalName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Conntry { get; set; }
        public string StoreNumber { get; set; }
        public string DCStore { get; set; }
        public long POItemID { get; set; }
        public Nullable<long> QuantityOrdered { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Upc { get; set; }
        public string Unit { get; set; }
        public string ItemDescription { get; set; }
        public Nullable<System.DateTime> ItemDeliveryDate { get; set; }
        public string DepartmentNumber { get; set; }
        public string BuyersVendorNumber { get; set; }
        public string MethodOfPayment { get; set; }
        public string RoutingCode { get; set; }
        public string Routing { get; set; }
    }
}
