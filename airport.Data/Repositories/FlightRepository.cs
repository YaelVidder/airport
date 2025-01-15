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
        public async Task<IEnumerable<Flight>> GetAllAsync()
        {
            return await _context.flights.ToListAsync();
        }

        public async Task<Flight> GetByIdAsync(int id)
        {
            return await _context.flights.Include(x => x.AirplanId)
                .Include(x => x.StatusId).FirstOrDefaultAsync(x => x.FlightId == id);
        }

        public async Task AddAsync(Flight flight)
        {
            _context.flights.Add(flight);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, Flight flight)
        {
            var index = _context.flights.ToList().FindIndex(x => x.FlightId == id);
            if (index != -1)
            {
                _context.flights.ToList()[index] = flight;
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            var flight = await GetByIdAsync(id);
            if (flight != null)
            {
                _context.flights.Remove(flight);
                await _context.SaveChangesAsync();
            }
        }

    }
}