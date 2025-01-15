using airport.Entities;

namespace airport.Api.Models
{
    public class FlightPostModel
    {
        public int FlightId { get; set; }
        public int AirplanId { get; set; }
        public int Source { get; set; }
        public int Destination { get; set; }
        public int StatusId { get; set; }
        public DateOnly TakingOffTime { get; set; }
        public DateOnly LandTime { get; set; }
    }
}
