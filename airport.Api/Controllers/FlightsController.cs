using airport.Core.Services;
using airport.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace airport.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {

        private readonly IFlightService _flightService;

        public FlightsController(IFlightService flightService)
        {
            _flightService = flightService;
        }


        [HttpGet]
        public ActionResult<Flight> Get()
        {
            return Ok(_flightService.GetList());
        }

        [HttpGet("{id}")]
        public ActionResult Get([FromRoute] int flightId)
        {
            var flight = _flightService.GetById(flightId);
            if (flight != null)
                return Ok(flight);
            return NotFound();
        }


        [HttpPost]
        public ActionResult Post([FromBody] Flight value)
        {
            _flightService.Add(value);
            return Ok(value);
        }

        [HttpPut("{id}")]
        public ActionResult<Flight> Put([FromRoute] int flightId, [FromBody] Flight value)
        {
            if (_flightService.GetById(flightId) == null)
                return NotFound();
            _flightService.Update(flightId, value);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            if (_flightService.GetById(id) == null)
                return NotFound();

            _flightService.Delete(id);
            return NoContent();
        }

    }
}
