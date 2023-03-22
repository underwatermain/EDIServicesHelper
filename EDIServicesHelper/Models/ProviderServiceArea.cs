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
    
    public partial class ProviderServiceArea
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProviderServiceArea()
        {
            this.BookingServices = new HashSet<BookingService>();
            this.QuotationProviders = new HashSet<QuotationProvider>();
        }
    
        public int ProviderServiceAreaID { get; set; }
        public int ProviderID { get; set; }
        public int ProviderServiceTypeID { get; set; }
        public string OriginAirportCode { get; set; }
        public string CountryCode { get; set; }
        public string StateCode { get; set; }
        public string PostalCode { get; set; }
        public string Name { get; set; }
        public string CurrencyCode { get; set; }
        public decimal CostPerKg { get; set; }
        public decimal CostPerItem { get; set; }
        public string DestinationAirportCode { get; set; }
        public string City { get; set; }
        public string TransitAirportCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingService> BookingServices { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual ProviderServiceType ProviderServiceType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuotationProvider> QuotationProviders { get; set; }
    }
}
