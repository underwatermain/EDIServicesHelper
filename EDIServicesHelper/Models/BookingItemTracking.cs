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
    
    public partial class BookingItemTracking
    {
        public long BookingItemTrackingID { get; set; }
        public long BookingItemID { get; set; }
        public int ProviderID { get; set; }
        public string TrackingNumber { get; set; }
        public string BOLNumber { get; set; }
        public Nullable<System.DateTime> AssignedDateTime { get; set; }
    
        public virtual BookingItem BookingItem { get; set; }
        public virtual Provider Provider { get; set; }
    }
}
