//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CricketStats.Datalayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Venue
    {
        public System.Guid venueid { get; set; }
        public string venuename { get; set; }
        public string venuecity { get; set; }
        public System.Guid countryid { get; set; }
        public Nullable<System.DateTime> lastupdated { get; set; }
    
        public virtual Country Country { get; set; }
    }
}