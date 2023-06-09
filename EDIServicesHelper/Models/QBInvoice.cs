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
    
    public partial class QBInvoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QBInvoice()
        {
            this.QBInvoiceItems = new HashSet<QBInvoiceItem>();
        }
    
        public int QBInvoiceID { get; set; }
        public Nullable<int> QBIDFromQB { get; set; }
        public Nullable<int> QBClientID { get; set; }
        public Nullable<System.DateTime> DateCreate { get; set; }
        public Nullable<System.DateTime> TxnDate { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public string InvoiceNumber { get; set; }
        public Nullable<System.DateTime> ShipDate { get; set; }
        public string Status { get; set; }
    
        public virtual QBClient QBClient { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QBInvoiceItem> QBInvoiceItems { get; set; }
    }
}
