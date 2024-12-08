using System.ComponentModel.DataAnnotations;

namespace airport.Entities
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public string LocationName { get; set; }

        public Location() { }
     
    }
}
