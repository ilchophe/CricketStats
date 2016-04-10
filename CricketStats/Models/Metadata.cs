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

    }

    public class BowlingInnMetadata
    {

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

        [Display(Name = "LastUpdated")]
        [DisplayFormat(ApplyFormatInEditMode = true, ConvertEmptyStringToNull = true, DataFormatString = "dd/MM/yyy")]
        public System.DateTime lastupdated { get; set; }
    }


    public class DismissalMetadata
    {

    }


    public class MatchMetadata
    {

    }

    public class MatchTypeMetadata
    {

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
        public System.DateTime dob { get; set; }

        [Display(Name = "Retired")]
        public Nullable<bool> retired { get; set; }

        [Display(Name = "LastUpdated")]
        public System.DateTime lastupdated { get; set; }

        [Display(Name = "Country")]
        public System.Guid countryid { get; set; }

    }

    public class VenueMetadata
    {

    }




}
