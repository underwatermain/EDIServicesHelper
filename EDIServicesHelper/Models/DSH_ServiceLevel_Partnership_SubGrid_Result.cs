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
    
    public partial class DSH_ServiceLevel_Partnership_SubGrid_Result
    {
        public string Hub { get; set; }
        public string Client { get; set; }
        public string PONumber { get; set; }
        public Nullable<long> ItemsQty { get; set; }
        public Nullable<System.DateTime> windowstart { get; set; }
        public Nullable<System.DateTime> windowEnd { get; set; }
        public Nullable<int> ShippedItems { get; set; }
        public string LastShipDate { get; set; }
        public Nullable<System.DateTime> LastEstDelivery { get; set; }
        public Nullable<int> ShippedQty { get; set; }
        public Nullable<int> ShipCount { get; set; }
        public Nullable<int> Invoice { get; set; }
        public Nullable<int> InvoiceItems { get; set; }
    }
}
