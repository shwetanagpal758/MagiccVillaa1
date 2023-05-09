using AutoMapper;
using MagicVilla.Web1.Models;
using MagicVilla.Web1.Models.Dto;

namespace MagicVilla.Web1
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            // vice versa bcoz we need to map a to b and b to a.
            // the below one is a time consuming method 
            CreateMap<VillaDTO, VillaCreateDTO>().ReverseMap();
            CreateMap<VillaDTO, VillaUpdateDTO>().ReverseMap();

            // shortcut way to map and also reverse map
            CreateMap<VillaNumberDTO, VillaNumberCreateDTO>().ReverseMap();

            CreateMap<VillaNumberDTO, VillaNumberUpdateDTO>().ReverseMap();



            // Automappings for villa number
        //    CreateMap<VillaNumber, VillaNumberDTO>().ReverseMap();

         //   CreateMap<VillaNumber, VillaNumberCreateDTO>().ReverseMap();

          //  CreateMap<VillaNumber, VillaNumberUpdateDTO>().ReverseMap();

        }
    }
}
