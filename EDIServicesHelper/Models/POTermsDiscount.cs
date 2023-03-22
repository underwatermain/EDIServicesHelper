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
    
    public partial class POTermsDiscount
    {
        public long POTermsDiscountsID { get; set; }
        public long PurchaseOrderID { get; set; }
        public string TypeCode { get; set; }
        public string BasisDateCode { get; set; }
        public Nullable<decimal> DiscountPercent { get; set; }
        public Nullable<System.DateTime> DiscountDueDate { get; set; }
        public Nullable<short> DiscountDaysDue { get; set; }
        public Nullable<System.DateTime> NetDueDate { get; set; }
        public Nullable<short> NetDays { get; set; }
        public Nullable<decimal> DiscountAmount { get; set; }
        public Nullable<System.DateTime> DeferredDueDate { get; set; }
        public Nullable<decimal> DeferredAmountDue { get; set; }
        public Nullable<decimal> PercentOfInvoicePayable { get; set; }
        public string Description { get; set; }
        public Nullable<byte> TermsDayOfMonth { get; set; }
        public string PaymentMethodCode { get; set; }
        public Nullable<decimal> AmountPercentforDeterminingLatePayment { get; set; }
    
        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}