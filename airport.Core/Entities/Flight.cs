using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace airport.Entities
{
    public class Flight
    {
        [Key]
        public int FlightId { get; set; }
        public int AirplanId { get; set; }
        public Airplane Airplane { get; set; }

        //public int SourceLocationId { get; set; }
         
        //public int DestinationLocationId { get; set; }
        public int StatusId { get; set; }
        public DateOnly TakingOffTime { get; set; }
        public DateOnly LandTime { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public Status status { get; set; }

        [ForeignKey("SourceLocation")]
        public Location SourceLoation { get; set; }
        [ForeignKey("DestinationLocation")]
        public Location DestinationLoation { get; set; }

    }
}
