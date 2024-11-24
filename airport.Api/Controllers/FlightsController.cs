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
        public ActionResult Get(int flightId)
        {
            var flight = _flightService.GetById(flightId);
            if (flight != null)
                return Ok(flight);
            return NotFound();
        }


        [HttpPost]
        public Flight Post([FromBody] Flight value)
        {
            _flightService.Add(value);
            return value;
        }

        [HttpPut("{id}")]
        public ActionResult<Flight> Put(int flightId, [FromBody] Flight value)
        {
            if(_flightService.GetById(flightId) == null)
                    return NotFound();
            return _flightService.Update(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int flightId)
        {
            var index = _flightService.GetList().FindIndex(f => f.flightId == flightId);
            _flightService.GetList().Remove(_flightService.GetList()[index]);
        }

    }
}
