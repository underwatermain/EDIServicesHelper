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
    
    public partial class IncomingDocumentDetail
    {
        public long IncomingDocumentDetailID { get; set; }
        public long IncomingDocument { get; set; }
        public long FileTransmission { get; set; }
        public string DocumentType { get; set; }
        public string DocumentContent { get; set; }
        public Nullable<int> Quantity { get; set; }
    
        public virtual DocumentType DocumentType1 { get; set; }
        public virtual FileTransmission FileTransmission1 { get; set; }
        public virtual IncomingDocument IncomingDocument1 { get; set; }
    }
}
