using airport.Api.Models;
using airport.Core.DTOs;
using airport.Core.Services;
using airport.Entities;
using airport.Service;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace airport.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {

        private readonly IFlightService _flightService;
        private readonly IMapper _mapper;

        public FlightsController(IFlightService flightService, IMapper mapper)
        {
            _flightService = flightService;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task <ActionResult<IEnumerable<flightDto>>> Get()
        {
            var flights =  await _flightService.GetListAsync();
            var flightsDto = _mapper.Map<IEnumerable<flightDto>>(flights);
            return Ok(flightsDto);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<flightDto>> Get([FromRoute] int flightId)
        {
            var flight = await _flightService.GetByIdAsync(flightId);
            if (flight == null)
                return NotFound();
            //var flightDto = _mapper.Map<flightDto>(flight);
            //return Ok(flightDto);
            return Ok(_mapper.Map<flightDto>(flight));
        }


        [HttpPost]
        public async Task<ActionResult> Post([FromBody] FlightPostModel flight)
        {
            //var flight = new Flight { AirplanId = value.AirplanId, Destination = value.Destination, FlightId = value.FlightId, 
            //    LandTime = value.LandTime, Source = value.Source, StatusId = value.StatusId, TakingOffTime = value.TakingOffTime };
            await _flightService.AddAsync(_mapper.Map<Flight>(flight));
            return Ok(flight);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Flight>> Put([FromRoute] int flightId, [FromBody] FlightPostModel flight)
        {
            if (await _flightService.GetByIdAsync(flightId) == null)
                return NotFound();
            if(flightId != flight.FlightId)
                return BadRequest();
            await _flightService.UpdateAsync(flightId, _mapper.Map<Flight>(flight));
            return Ok(flight);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync([FromRoute] int id)
        {
            if (await _flightService.GetByIdAsync(id) == null)
                return NotFound();

            await _flightService.DeleteAsync(id);
            return NoContent();
        }

    }
}
