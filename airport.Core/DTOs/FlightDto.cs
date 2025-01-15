using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airport.Core.DTOs
{
    public class flightDto
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
