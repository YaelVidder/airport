using System.ComponentModel.DataAnnotations;

namespace airport.Entities
{
    public class Status
    {
        [Key]
        public int StatusId { get; set; }
        public string Describe { get; set; }
    }
}
