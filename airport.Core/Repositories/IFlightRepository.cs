using airport.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airport.Core.Repositories
{
    public interface IFlightRepository
    {
        public List<Flight> GetAll();

        public Flight GetById(int id);

        public void Add(Flight flight);

        public void Update(int id, Flight flight);

        public void Delete(int id);
    }
}