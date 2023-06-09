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
    
    public partial class BookingEvent
    {
        public long BookingEventID { get; set; }
        public long BookingItemID { get; set; }
        public int OriginProviderID { get; set; }
        public int DestinationProviderID { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public string EventDescription { get; set; }
        public Nullable<System.DateTime> EventDate { get; set; }
    
        public virtual BookingItem BookingItem { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual Provider Provider1 { get; set; }
    }
}
