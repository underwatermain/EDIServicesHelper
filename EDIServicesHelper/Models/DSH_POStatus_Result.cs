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
    
    public partial class DSH_POStatus_Result
    {
        public string ShipFrom { get; set; }
        public string ShipTo { get; set; }
        public long PurchaseOrderID { get; set; }
        public string Hub { get; set; }
        public string Client { get; set; }
        public string PONumber { get; set; }
        public string PODate { get; set; }
        public string ProcessedOn { get; set; }
        public string ShipStart { get; set; }
        public string ShipEnd { get; set; }
        public string PODateBeforeVal { get; set; }
        public string ShipStartVal { get; set; }
        public string PODateAfterVal { get; set; }
        public string ShipEndVal { get; set; }
        public Nullable<int> ItemQty { get; set; }
        public Nullable<long> TotalOrdered { get; set; }
        public Nullable<int> TotalShipped { get; set; }
        public Nullable<int> TotalBilled { get; set; }
        public Nullable<int> ASNs { get; set; }
        public string LastASNDate { get; set; }
        public Nullable<int> Invoices { get; set; }
        public string LastInvoiceDate { get; set; }
        public string Status { get; set; }
        public string FileName { get; set; }
        public string LastResetDateTime { get; set; }
    }
}
