using airport.Core.Repositories;
using airport.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airport.Data.Repositories
{
    public class FlightRepository: IFlightRepository
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
    }
}
