using airport.Core.Repositories;
using airport.Core.Services;
using airport.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airport.Service
{
    public class FlightService : IFlightService
    {
        private readonly IFlightRepository _flightRepository;

        public FlightService(IFlightRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }
        public IEnumerable<Flight> GetList()
        {
            return _flightRepository.GetAll();
        }

        public Flight GetById(int id)
        {
            return _flightRepository.GetById(id);
        }

        public void Add(Flight flight)
        {
            _flightRepository.Add(flight);
        }

        public void Update(int id, Flight flight)
        {
            _flightRepository.Update(id, flight);
        }

        public void Delete(int id)
        {
            _flightRepository.Delete(id);
        }
    }
}