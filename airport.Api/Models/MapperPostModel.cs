using airport.Entities;
using AutoMapper;

namespace airport.Api.Models
{
    public class MapperPostModel: Profile
    {
        public MapperPostModel()
        {
            CreateMap<FlightPostModel, Flight>().ReverseMap();
        }
    }
}
