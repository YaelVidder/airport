using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace airport.Entities
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
       
    }
}
