using System.ComponentModel.DataAnnotations;

namespace airport.Entities
{
    public class Status
    {
        [Key]
        public int statusId { get; set; }
        public string describe { get; set; }

        //public Status(int statusId, string describe)
        //{
        //    this.statusId = statusId;
        //    this.describe = describe;
        //}
    }
}
