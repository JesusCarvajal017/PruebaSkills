using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dto.Pizza;
using Entity.Dtos.Security.Form;
using Entity.Model.Pizza;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Security
{
    public class PizzaController
       : GenericController<
       Entity.Model.Pizza.Pizza,
       PizzaDto,
       PizzaDto>
    {
        public PizzaController(
            IQueryServices<Entity.Model.Pizza.Pizza, PizzaDto> q,
            ICommandService<Entity.Model.Pizza.Pizza, PizzaDto> c)
          : base(q, c) { }
    }

}
