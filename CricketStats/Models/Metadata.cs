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
        [StringLength(100)]
        [Display(Name = "Player Name")]
        public string playername;

        [StringLength(100)]
        [Display(Name = "Player Surname")]
        public string playersurname;



    }

    public class VenueMetadata
    {

    }




}
