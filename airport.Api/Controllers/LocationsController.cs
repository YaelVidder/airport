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
        public IEnumerable<Location> Get()
        {
            return _locationService.GetList();
        }

        [HttpGet("{id}")]
        public Location Get(int LocationId)
        {
            return _locationService.GetList().FirstOrDefault(l => l.LocationId == LocationId);
        }

        /*
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
        */

    }
}
