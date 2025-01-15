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


        public async Task <IEnumerable<Flight>> GetListAsync()
        {
            return await _flightRepository.GetAllAsync();
        }

        public async Task <Flight> GetByIdAsync(int id)
        {
            return await _flightRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(Flight flight)
        {
            await _flightRepository.AddAsync(flight);
        }

        public async Task UpdateAsync(int id, Flight flight)
        {
            await _flightRepository.UpdateAsync(id, flight);
        }

        public async Task DeleteAsync(int id)
        {
            await _flightRepository.DeleteAsync(id);
        }
    }
}