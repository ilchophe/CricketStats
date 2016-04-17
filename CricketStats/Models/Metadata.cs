using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace CricketStats.Models
{


    public class BattingInnMetadata
    {
        public System.Guid BatInnsid { get; set; }

        [Display(Name = "Match")]
        public System.Guid matchid { get; set; }

        [Display(Name = "Inns")]
        public short BatInnsNumber { get; set; }

        [Display(Name = "Country")]
        public System.Guid countryid { get; set; }

        [Display(Name = "Batsman")]
        public System.Guid playerid { get; set; }

        [Display(Name = "Runs")]
        public int runs { get; set; }

        [Display(Name = "Balls")]
        public int ballsfaced { get; set; }

        [Display(Name = "Fours")]
        public int fours { get; set; }

        [Display(Name = "Sixes")]
        public int sixes { get; set; }

        [Display(Name = "Bowler")]
        public Nullable<System.Guid> bowler_playerid { get; set; }

        [Display(Name = "Fielder")]
        public Nullable<System.Guid> fielder_playerid { get; set; }

        [Display(Name = "Dismissal")]
        public System.Guid dismissalid { get; set; }

        [Display(Name = "Last Updated")]
        public System.DateTime lastupdated { get; set; }
    }

    public class BowlingInnMetadata
    {
        public System.Guid bowlingInnsid { get; set; }

        [Display(Name = "Match")]
        public System.Guid matchid { get; set; }

        [Display(Name = "Inns")]
        public short bowlingInnsnumber { get; set; }

        [Display(Name = "Country")]
        public System.Guid countryid { get; set; }

        [Display(Name = "Bowler")]
        public System.Guid playerid { get; set; }

        [Display(Name = "Runs")]
        public Nullable<int> runs { get; set; }

        [Display(Name = "Wickets")]
        public Nullable<int> wickets { get; set; }

        [Display(Name = "Maidens")]
        public Nullable<int> maidens { get; set; }

        [Display(Name = "Overs")]
        public Nullable<int> overs { get; set; }
        
        [Display(Name = "Extras")]
        public Nullable<int> extras { get; set; }

        [Display(Name = "Last Updated")]
        public System.DateTime lastupdated { get; set; }
    }

    public class CountryMetadata
    {
        public System.Guid countryid { get; set; }

        [StringLength(50)]
        [Display(Name = "Code")]
        public string countrycode { get; set; }

        [StringLength(100)]
        [Display(Name = "Country")]
        public string countrydesc { get; set; }

        [Display(Name = "Last Updated")]
        [DisplayFormat(ApplyFormatInEditMode = true, ConvertEmptyStringToNull = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public System.DateTime lastupdated { get; set; }
    }


    public class DismissalMetadata
    {

        public System.Guid dismissalid { get; set; }

        [Display(Name = "Code")]
        public string dismissalcode { get; set; }

        [Display(Name = "Description")]
        public string dismissaldesc { get; set; }

        [Display(Name = "Last Updated")]
        public System.DateTime lastupdated { get; set; }
    }


    public class MatchMetadata
    {
        public System.Guid matchid { get; set; }

        [Display(Name = "Match")]
        public short matchnumber { get; set; }

        [Display(Name = "Home Country")]
        public System.Guid homecountryid { get; set; }

        [Display(Name = "Country")]
        public System.Guid awaycountryid { get; set; }

        [Display(Name = "Venue")]
        public System.Guid venueid { get; set; }

        [Display(Name = "Match Type")]
        public System.Guid matchtypeid { get; set; }

        [Display(Name = "Start Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, ConvertEmptyStringToNull = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public Nullable<System.DateTime> matchstartdate { get; set; }

        [Display(Name = "Toss Won")]
        public System.Guid tosswinnercountryid { get; set; }

        [Display(Name = "Last Updated")]
        public System.DateTime lastupdated { get; set; }
    }

    public class MatchTypeMetadata
    {
        public System.Guid matchtypeid { get; set; }

        [StringLength(100)]
        [Display(Name = "Match Type Name")]
        public string matchtypename { get; set; }

        [Display(Name = "Last Updated")]
        public System.DateTime lastupdated { get; set; }
    }

    public class PlayerMetadata
    {

        public System.Guid playerid { get; set; }

        [StringLength(100)]
        [Display(Name = "Name")]
        public string playername;

        [StringLength(100)]
        [Display(Name = "Surname")]
        public string playersurname;

        [Display(Name = "Date of Birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, ConvertEmptyStringToNull = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public System.DateTime dob { get; set; }

        [Display(Name = "Retired")]
        public Nullable<bool> retired { get; set; }

        [Display(Name = "Last Updated")]
        public System.DateTime lastupdated { get; set; }

        [Display(Name = "Country")]
        public System.Guid countryid { get; set; }


    }

    public class VenueMetadata
    {
        public System.Guid venueid { get; set; }

        [StringLength(100)]
        [Display(Name = "Venue Name")]
        public string venuename { get; set; }

        [StringLength(100)]
        [Display(Name = "City")]
        public string venuecity { get; set; }

        [Display(Name = "Country")]
        public System.Guid countryid { get; set; }

        [Display(Name = "Last Updated")]
        public Nullable<System.DateTime> lastupdated { get; set; }
    }




}
