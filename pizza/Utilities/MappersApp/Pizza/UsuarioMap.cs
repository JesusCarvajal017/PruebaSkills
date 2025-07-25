using AutoMapper;
using Entity.Dto.Pizza;
using Entity.Dtos.Security.Form;
using Entity.Model.Pizza;

namespace Utilities.MappersApp.Pizza
{
    public class UsuarioMap : Profile
    {
        public UsuarioMap()
        {
            CreateMap<Usuario, UsuarioDto>().ReverseMap();
        }
    }
}