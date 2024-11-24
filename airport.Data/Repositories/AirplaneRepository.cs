using airport.Core.Repositories;
using airport.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airport.Data.Repositories
{
    public class AirplaneRepository : IAirplaneRepository
    {

        public readonly DataContext _context;

        public AirplaneRepository(DataContext context)
        {
            _context = context;
        }
        public List<Airplane> GetAll()
        {
            return _context.airplanes.ToList();
        }

        public Airplane GetById(int id)
        {
            return _context.airplanes.FirstOrDefault(a => a.airplanId == id);
        }

    }
}
