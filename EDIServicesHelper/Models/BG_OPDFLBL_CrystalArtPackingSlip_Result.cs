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
    
    public partial class BG_OPDFLBL_CrystalArtPackingSlip_Result
    {
        public long advanceShipNoticeID { get; set; }
        public string packageNumber { get; set; }
        public long poID { get; set; }
        public string poNumber { get; set; }
        public Nullable<System.DateTime> poDate { get; set; }
        public string customerOrderNo { get; set; }
        public string returnMesage { get; set; }
        public string routing { get; set; }
        public Nullable<System.DateTime> shipDate { get; set; }
        public string addressNameST { get; set; }
        public string additionalName { get; set; }
        public string addressCode { get; set; }
        public string addressST { get; set; }
        public string cityST { get; set; }
        public string stateST { get; set; }
        public string postalCodeST { get; set; }
        public string lineItem { get; set; }
        public int quantityShipped { get; set; }
        public string itemNumber { get; set; }
        public string itemStyleNumber { get; set; }
        public string UPC { get; set; }
        public string itemDescription { get; set; }
        public string unit { get; set; }
    }
}