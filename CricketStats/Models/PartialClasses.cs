using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace CricketStats.Models
{

    [MetadataType(typeof(BattingInnMetadata))]
    public partial class BattingInn
    {
    }

    [MetadataType(typeof(BowlingInnMetadata))]
    public partial class BowlingInn
    {
    }

    [MetadataType(typeof(CountryMetadata))]
    public partial class Country
    {
    }

    [MetadataType(typeof(DismissalMetadata))]
    public partial class Dismissal
    {
    }

    [MetadataType(typeof(MatchMetadata))]
    public partial class Match
    {
    }

    [MetadataType(typeof(MatchTypeMetadata))]
    public partial class MatchType
    {
    }

    [MetadataType(typeof(PlayerMetadata))]
    public partial class Player
    {
    }

    [MetadataType(typeof(VenueMetadata))]
    public partial class Venue
    {
    }



}
