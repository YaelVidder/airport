using System.ComponentModel.DataAnnotations;

namespace airport.Entities
{
    public class Airplane
    {
        [Key]
        public int airplanId { get; set; }
        public string airplaneType { get; set; }

        //public Airplane(int airplanId, string airplaneType)
        //{
        //    this.airplanId = airplanId;
        //    this.airplaneType = airplaneType;
        //}
    }
}
