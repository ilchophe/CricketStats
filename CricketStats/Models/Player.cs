//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CricketStats.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Player
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Player()
        {
            this.BattingInns = new HashSet<BattingInn>();
            this.BattingInns1 = new HashSet<BattingInn>();
            this.BattingInns2 = new HashSet<BattingInn>();
            this.BowlingInns = new HashSet<BowlingInn>();
        }
    
        public System.Guid playerid { get; set; }
        public string playername { get; set; }
        public string playersurname { get; set; }
        public System.Guid countryid { get; set; }
        public System.DateTime dob { get; set; }
        public Nullable<bool> retired { get; set; }
        public System.DateTime lastupdated { get; set; }
    
        public virtual Country Country { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BattingInn> BattingInns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BattingInn> BattingInns1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BattingInn> BattingInns2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BowlingInn> BowlingInns { get; set; }
    }
}
