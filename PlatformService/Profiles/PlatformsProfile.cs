using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles {


    public class PlatformsProfile : Profile {

         public PlatformsProfile()
         {
             //source -> target

             CreateMap<Platfrom,PlatfromReadDto>();
             CreateMap<PlatformCreateDto, Platfrom>();
         }
    }
}