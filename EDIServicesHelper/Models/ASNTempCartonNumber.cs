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
    using System.Collections.Generic;
    
    public partial class ASNTempCartonNumber
    {
        public int ASNTempCartonNumberID { get; set; }
        public Nullable<long> FileTransmissionID { get; set; }
        public int SourceTP { get; set; }
        public int DestTP { get; set; }
        public string ItemCode { get; set; }
        public string UPC { get; set; }
        public Nullable<int> QuantityShipped { get; set; }
        public string PackageNumber { get; set; }
        public string PONumber { get; set; }
        public Nullable<long> PackageID { get; set; }
    }
}
