using System.ComponentModel.DataAnnotations;

namespace airport.Entities
{
    public class Flight
    {
        [Key]
        public int FlightId { get; set; }
        public int AirplanId { get; set; }
        public Airplane Airplane { get; set; }
        public int Source { get; set; }
        public int Destination { get; set; }
        public int StatusId { get; set; }
        public Status status { get; set; }
        public DateOnly TakingOffTime { get; set; }
        public DateOnly LandTime { get; set; }
            
    }
}
