using AutoMapper;
using Hotel.Models;

namespace Hotel
{
    public static class MapperConfig 
    {
        public static MapperConfiguration RegirsterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
              {
                  config.CreateMap<Hotel.Models.Hotel,Room>().ReverseMap();

              });return mappingConfig;
        }
    }
}
