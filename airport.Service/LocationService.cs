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
    public class LocationService: ILocationService
    {
        private readonly ILocationRepository _locationRepository;

        public LocationService(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }
        public List<Location> GetList()
        {
            return _locationRepository.GetAll();
        }
    }
}
