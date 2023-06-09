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
    
    public partial class POItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public POItem()
        {
            this.ASNItems = new HashSet<ASNItem>();
            this.InvoiceItems = new HashSet<InvoiceItem>();
            this.POItemReferences = new HashSet<POItemReference>();
            this.POSubItems = new HashSet<POSubItem>();
            this.POItemAddresses = new HashSet<POItemAddress>();
            this.POItemDates = new HashSet<POItemDate>();
            this.POItemSpecifications = new HashSet<POItemSpecification>();
        }
    
        public long POItemID { get; set; }
        public long PurchaseOrderID { get; set; }
        public string LineItem { get; set; }
        public Nullable<long> QuantityOrdered { get; set; }
        public string Unit { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string PriceCode { get; set; }
        public string ItemNumber { get; set; }
        public string Sku { get; set; }
        public string CarryOverPartNumber { get; set; }
        public string ModelNumber { get; set; }
        public string ManufcPartNumber { get; set; }
        public string BuyersCatalogue { get; set; }
        public string BuyersPartNumber { get; set; }
        public string Upc { get; set; }
        public string UpcEan { get; set; }
        public string VendorsPartNumber { get; set; }
        public string ItemCode { get; set; }
        public string VendorsItemNumber { get; set; }
        public string VendorsCatalogue { get; set; }
        public string VendorsStyleNumber { get; set; }
        public string ItemDescriptionType { get; set; }
        public string ProductCharacterCode { get; set; }
        public string AgencyQualifierCode { get; set; }
        public string ProductDescriptionCode { get; set; }
        public string ItemDescription { get; set; }
        public string MessageText { get; set; }
        public string EntityIdentifierCode { get; set; }
        public string Name { get; set; }
        public string ISBN { get; set; }
        public string CaseCode { get; set; }
        public string ShippingContainerCode { get; set; }
        public string Message { get; set; }
        public string LiteralText { get; set; }
        public Nullable<long> Pack { get; set; }
        public Nullable<decimal> GrossWeightPerPack { get; set; }
        public string GrossWeightUnit { get; set; }
        public string SizeCode { get; set; }
        public string VendorColorDescription { get; set; }
        public string VendorSizeDescription { get; set; }
        public Nullable<long> InnerPack { get; set; }
        public string GeneralItemType { get; set; }
        public string MiscelllaneousUnit { get; set; }
        public string BuyersStyleNumber { get; set; }
        public Nullable<decimal> RetailPrice { get; set; }
        public Nullable<decimal> ResaleUnitPrice { get; set; }
        public string GenericQualifier1 { get; set; }
        public string GenericID1 { get; set; }
        public string GenericQualifier2 { get; set; }
        public string GenericID2 { get; set; }
        public string CarrierDetailLocation { get; set; }
        public string TaxIdentificationNumber { get; set; }
        public Nullable<decimal> QuantityOrderedDecimal { get; set; }
        public Nullable<decimal> GrossWidthPerPack { get; set; }
        public Nullable<decimal> GrossLengthPerPack { get; set; }
        public Nullable<decimal> GrossHeightPerPack { get; set; }
        public string GrossLengthUnit { get; set; }
        public Nullable<decimal> PromotionalPrice { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASNItem> ASNItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceItem> InvoiceItems { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POItemReference> POItemReferences { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POSubItem> POSubItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POItemAddress> POItemAddresses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POItemDate> POItemDates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POItemSpecification> POItemSpecifications { get; set; }
    }
}
