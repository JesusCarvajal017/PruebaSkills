using AutoMapper;
using Entity.Dto.Pizza;
using Entity.Dtos.Security.Form;
using Entity.Model.Pizza;

namespace Utilities.MappersApp.Pizza
{
    public class ClienteMap : Profile
    {
        public ClienteMap()
        {
            CreateMap<Cliente, ClienteDto>().ReverseMap();
        }
    }
}