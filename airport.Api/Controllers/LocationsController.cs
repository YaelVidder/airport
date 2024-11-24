using airport.Core.Services;
using airport.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private ILocationService _locationService;

        public LocationsController(ILocationService locationService)
        {
            _locationService = locationService;
        }
    

    [HttpGet]
        public ActionResult<Location> Get()
        {
            return Ok(_locationService.GetList());
        }

        [HttpGet("{id}")]
        public ActionResult Get([FromRoute]int LocationId)
        {
            var location = _locationService.GetById(LocationId);
            if(location != null) 
                return Ok(location);
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
