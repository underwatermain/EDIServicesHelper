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
    
    public partial class QuotationServiceArea
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuotationServiceArea()
        {
            this.QuotationProviders = new HashSet<QuotationProvider>();
        }
    
        public int QuotationServiceAreaID { get; set; }
        public int QuotationID { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string PostalCodes { get; set; }
        public Nullable<int> AverageItems { get; set; }
        public Nullable<decimal> AverageKGWeight { get; set; }
    
        public virtual Quotation Quotation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuotationProvider> QuotationProviders { get; set; }
    }
}
