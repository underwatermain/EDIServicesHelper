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
    
    public partial class PORelatedInstruction
    {
        public long PORelatedInstructionID { get; set; }
        public long PurchaseOrderID { get; set; }
        public string MethodOfPayment { get; set; }
        public string OrderMethodOfPayment { get; set; }
        public string LocationQualifier { get; set; }
        public string Description1 { get; set; }
        public string TermsQualifierCode { get; set; }
        public string TransportationTermsCode { get; set; }
        public string LocationQualifierTitle { get; set; }
        public string Description2 { get; set; }
        public string RiskOfLossTransfer { get; set; }
        public string Description3 { get; set; }
    
        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}