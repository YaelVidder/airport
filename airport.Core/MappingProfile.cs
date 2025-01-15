using airport.Core.DTOs;
using airport.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airport.Core
{
    public class MappingProfile: Profile
    {
        public MappingProfile() 
        {
            CreateMap<Flight, flightDto>().ReverseMap();
        }
    }
}
