using airport.Core.Repositories;
using airport.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airport.Data.Repositories
{
    public class StatusRepository:IStatusRepository
    {
        public readonly DataContext _context;

        public StatusRepository(DataContext context)
        {
            _context = context;
        }
        public List<Status> GetAll()
        {
            return _context.statuses;
        }
    }
}
