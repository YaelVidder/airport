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

        public void Update(int id, Flight flight)
        {
            var index = _context.flights.ToList().FindIndex(x => x.flightId == id);
            if(index != -1) 
                 _context.flights.ToList()[index] = flight;
        }

        public void Delete(int id)
        {
            var flight = GetById(id);
            if(flight != null)
                _context.flights.Remove(flight);
        }

    }
}