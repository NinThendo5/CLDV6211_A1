using System.ComponentModel.DataAnnotations;

namespace EventsApp.Models
{
    public class Venue
    {
        [Key]

        public int VenueId { get; set; }

        public string VenueName { get; set; }

        public string Location { get; set; }

        public List<Gameplay> Gameplays { get; set; }

    }
}
