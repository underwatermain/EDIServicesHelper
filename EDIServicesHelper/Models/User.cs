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
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.UserOperations = new HashSet<UserOperation>();
            this.UserTradingPartners = new HashSet<UserTradingPartner>();
        }
    
        public long UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Roles { get; set; }
        public Nullable<int> TradingPartnerID { get; set; }
        public bool Active { get; set; }
        public string EMail { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<bool> Validated { get; set; }
        public Nullable<short> GMT { get; set; }
        public Nullable<bool> DST { get; set; }
        public string AuthorizationToken { get; set; }
    
        public virtual TradingPartner TradingPartner { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserOperation> UserOperations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserTradingPartner> UserTradingPartners { get; set; }
    }
}