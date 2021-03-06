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
    
    public partial class BattingInn
    {
        public System.Guid BatInnsid { get; set; }
        public System.Guid matchid { get; set; }
        public short BatInnsNumber { get; set; }
        public System.Guid countryid { get; set; }
        public System.Guid playerid { get; set; }
        public int runs { get; set; }
        public int ballsfaced { get; set; }
        public int fours { get; set; }
        public int sixes { get; set; }
        public Nullable<System.Guid> bowler_playerid { get; set; }
        public Nullable<System.Guid> fielder_playerid { get; set; }
        public System.Guid dismissalid { get; set; }
        public System.DateTime lastupdated { get; set; }
    
        public virtual Dismissal Dismissal { get; set; }
        public virtual Country Country { get; set; }
        public virtual Match Match { get; set; }
        public virtual Player Player { get; set; }
        public virtual Player PlayerBowler { get; set; }
        public virtual Player PlayerFielder { get; set; }
    }
}
