using AutoMapper;
using Entity.Dto.Pizza;
using Entity.Dtos.Security.Form;
using Entity.Model.Pizza;

namespace Utilities.MappersApp.Pizza
{
    public class PedidoMap : Profile
    {
        public PedidoMap()
        {
            CreateMap<Pedidos, PedidosDto>().ReverseMap();
        }
    }
}