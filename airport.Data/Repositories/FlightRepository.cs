using airport.Core.Repositories;
using airport.Core.Services;
using airport.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airport.Data.Repositories
{
    public class FlightRepository : IFlightRepository
    {
        public readonly DataContext _context;

        public FlightRepository(DataContext context)
        {
            _context = context;
        }
        public List<Flight> GetAll()
        {
            return _context.flights.ToList();
        }

        public Flight GetById(int id)
        {
            return _context.flights.FirstOrDefault(x => x.flightId == id);
        }

        public void Add(Flight flight)
        {
            _context.flights.Add(flight);
        }

        public Flight Update(Flight flight)
        {
            _context.flights.Update(flight);
            var index = _context.flights.ToList().FindIndex(x => x.flightId == flight.flightId);
            //_context.flights.ToList()[index].airplanId = flight.airplanId;
            //_context.flights.ToList()[index].source = flight.source;
            //_context.flights.ToList()[index].destination = flight.destination;
            //_context.flights.ToList()[index].status = flight.status;
            //_context.flights.ToList()[index].takingOffTime = flight.takingOffTime;
            //_context.flights.ToList()[index].landTime = flight.landTime;
            return _context.flights.ToList()[index];
        }

    }
}
