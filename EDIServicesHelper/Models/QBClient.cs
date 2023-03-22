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
    
    public partial class QBClient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QBClient()
        {
            this.QBBillingAddresses = new HashSet<QBBillingAddress>();
            this.QBInvoices = new HashSet<QBInvoice>();
            this.QBShipAddresses = new HashSet<QBShipAddress>();
            this.TradingPartners = new HashSet<TradingPartner>();
        }
    
        public int QBClientID { get; set; }
        public int QBID { get; set; }
        public string CompanyName { get; set; }
        public string DisplayName { get; set; }
        public string GivenName { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> Organization { get; set; }
        public string Title { get; set; }
        public string ContactName { get; set; }
        public string AltContactName { get; set; }
        public Nullable<bool> Job { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public Nullable<System.DateTime> OpenBalanceDate { get; set; }
        public Nullable<decimal> BalanceWithJobs { get; set; }
        public Nullable<decimal> CreditLimit { get; set; }
        public string AcctNum { get; set; }
        public string ResaleNum { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QBBillingAddress> QBBillingAddresses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QBInvoice> QBInvoices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QBShipAddress> QBShipAddresses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TradingPartner> TradingPartners { get; set; }
    }
}
