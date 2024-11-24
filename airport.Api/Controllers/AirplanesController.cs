using airport.Core.Services;
using airport.Entities;
using airport.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirplanesController : ControllerBase
    {
        private readonly IAirplaneService _airplaneService;
        public AirplanesController(IAirplaneService airplaneService)
        {
            _airplaneService = airplaneService;
        }

        [HttpGet]
        public ActionResult<Airplane> Get()
        {
            return Ok(_airplaneService.GetList());
        }

        [HttpGet("{id}")]
        public ActionResult Get([FromRoute] int airplanId)
        {
            var airplane = _airplaneService.GetById(airplanId);
            if(airplane != null) 
                return Ok(airplane);
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
