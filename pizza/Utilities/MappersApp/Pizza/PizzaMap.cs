using AutoMapper;
using Entity.Dto.Pizza;
using Entity.Dtos.Security.Form;
using Entity.Model.Pizza;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Utilities.MappersApp.Pizza
{
    public class PizzaMap : Profile
    {
        public PizzaMap()
        {
            CreateMap<Entity.Model.Pizza.Pizza, PizzaDto>().ReverseMap();
        }
    }
}