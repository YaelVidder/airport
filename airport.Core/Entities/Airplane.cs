using System.ComponentModel.DataAnnotations;

namespace airport.Entities
{
    public class Airplane
    {
        [Key]
        public int AirplanId { get; set; }
        public string AirplaneType { get; set; }     
    }
}
