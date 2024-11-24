using airport.Core.Services;
using airport.Entities;
using airport.Service;
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
        public ActionResult<Company> Get()
        {
            return Ok(_companyService.GetList());
        }

        [HttpGet("{id}")]
        public ActionResult Get([FromRoute] int companyId)
        {
            var company = _companyService.GetById(companyId);
            if (company != null) 
                return Ok(company);
            return NotFound();
        }

  

        /*
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
        */

    }
}
