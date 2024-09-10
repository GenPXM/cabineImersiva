using AutoMapper;
using CabineImersivaApi.DTO;
using CabineImersivaApi.Models;

namespace CabineImersivaApi.Profiles

{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {
            CreateMap<UsuarioDto, Usuario>();

        }
    }
}
