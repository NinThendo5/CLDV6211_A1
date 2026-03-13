using System.ComponentModel.DataAnnotations;

namespace EventsApp.Models
{
    public class Gameplay
    {
        [Key] public int GameplayId { get; set; }
        public int VenueID { get; set; }
        public Venue? Venue { get; set; }
    }
}
