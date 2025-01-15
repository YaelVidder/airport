using airport.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airport.Core.Services
{
    public interface IFlightService
    {
        public Task <IEnumerable<Flight>> GetListAsync();
        public Task <Flight> GetByIdAsync(int id);

        public Task AddAsync(Flight flight);

        public Task UpdateAsync(int id,Flight flight);

        public Task DeleteAsync(int id);
    }
}