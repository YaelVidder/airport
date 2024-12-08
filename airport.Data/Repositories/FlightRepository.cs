using airport.Core.Repositories;
using airport.Core.Services;
using airport.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace airport.Data.Repositories
{
    public class FlightRepository : IFlightRepository
    {
        public readonly DataContext _context;

        public FlightRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Flight> GetAll()
        {
            return _context.flights.ToList();
        }

        public Flight GetById(int id)
        {
            return _context.flights.Include(x => x.AirplanId)
                .Include(x => x.StatusId).FirstOrDefault(x => x.FlightId == id);
        }

        public void Add(Flight flight)
        {
            _context.flights.Add(flight);
            _context.SaveChanges();
        }

        public void Update(int id, Flight flight)
        {
            var index = _context.flights.ToList().FindIndex(x => x.FlightId == id);
            if (index != -1)
            {
                _context.flights.ToList()[index] = flight;
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var flight = GetById(id);
            if (flight != null)
            {
                _context.flights.Remove(flight);
                _context.SaveChanges();
            }
        }

    }
}