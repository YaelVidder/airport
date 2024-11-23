using airport.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airport.Core.Repositories
{
    public interface IStatusRepository
    {
        public List<Status> GetAll();
    }
}
