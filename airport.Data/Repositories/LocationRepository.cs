using airport.Core.Repositories;
using airport.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airport.Data.Repositories
{
    public class LocationRepository:ILocationRepository
    {
        public readonly DataContext _context;

        public LocationRepository(DataContext context)
        {
            _context = context;
        }
        public List<Location> GetAll()
        {
            return _context.locations;
        }

        public Location GetById(int id)
        {
            return _context.locations.FirstOrDefault(l => l.LocationId == id);
        }

    }
}
