using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace airport.Entities
{
    public class Company
    {
        [Key]
        public int companyId { get; set; }
        public string companyName { get; set; }

        //public Company(int companyId, string companyName)
        //{
        //    this.companyId = companyId;
        //    this.companyName = companyName;
        //}
    }
}
