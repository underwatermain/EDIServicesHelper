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
    
    public partial class BookingItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BookingItem()
        {
            this.BookingEvents = new HashSet<BookingEvent>();
            this.BookingItemTrackings = new HashSet<BookingItemTracking>();
        }
    
        public long BookingItemID { get; set; }
        public int BookingID { get; set; }
        public string OrderNo { get; set; }
        public string RecipientName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string PostalCode { get; set; }
        public string CountryCode { get; set; }
        public Nullable<int> ParcelCount { get; set; }
        public Nullable<decimal> ConsignementWeight { get; set; }
        public string ProductTypeDescription { get; set; }
        public decimal SingleUnitValueOfProduct { get; set; }
        public string CountryOfOrigin { get; set; }
        public string HTSCode { get; set; }
        public decimal ProductUnitWeight { get; set; }
        public int ProductQuantity { get; set; }
        public string DetailedProductDescription { get; set; }
        public string ConstructionComposition { get; set; }
        public string EndContactEmail { get; set; }
        public string ProductCode { get; set; }
        public string EndContactPhone { get; set; }
        public string EndContactMobile { get; set; }
        public string ParcelCode { get; set; }
        public string DeliveryType { get; set; }
        public string CarrierConsignementCode { get; set; }
        public Nullable<int> ParcelIndex { get; set; }
        public string ServiceCode { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerNumber { get; set; }
        public string DeliveryLocationCode { get; set; }
        public Nullable<decimal> ParcelWeight { get; set; }
        public string SenderName { get; set; }
        public string SenderAddress1 { get; set; }
        public string SenderAddress2 { get; set; }
        public string SenderCity { get; set; }
        public string SenderState { get; set; }
        public string SenderPostcode { get; set; }
        public string SenderCountryCode { get; set; }
        public string CurrencyCode { get; set; }
        public string PersonalIDNo { get; set; }
        public string ChainID { get; set; }
    
        public virtual Booking Booking { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingEvent> BookingEvents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingItemTracking> BookingItemTrackings { get; set; }
    }
}
