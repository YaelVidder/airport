using airport.Core.Services;
using airport.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {

        private readonly ICompanyService _companyService;
        public CompaniesController(ICompanyService companyService)
        {
            _companyService = companyService;
        }


        [HttpGet]
        public IEnumerable<Company> Get()
        {
            return _companyService.GetList();
        }

        [HttpGet("{id}")]
        public Company Get(int companyId)
        {
            return _companyService.GetList().FirstOrDefault(c => c.companyId == companyId);
        }


        /*
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
        */

    }
}
