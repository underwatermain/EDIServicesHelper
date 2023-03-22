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
    
    public partial class Channel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Channel()
        {
            this.Messages = new HashSet<Message>();
            this.MessageActions = new HashSet<MessageAction>();
            this.PartnershipDocumentChannels = new HashSet<PartnershipDocumentChannel>();
        }
    
        public int ChanelID { get; set; }
        public int EnvironmentID { get; set; }
        public int TradingPartnerID { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string AdditionalInfo { get; set; }
        public bool Active { get; set; }
        public Nullable<bool> MustRead { get; set; }
        public Nullable<bool> CanWrite { get; set; }
        public Nullable<bool> MustDelete { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsSetup { get; set; }
    
        public virtual Environment Environment { get; set; }
        public virtual TradingPartner TradingPartner { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message> Messages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MessageAction> MessageActions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartnershipDocumentChannel> PartnershipDocumentChannels { get; set; }
    }
}
