using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dto.Pizza;
using Entity.Dtos.Security.Form;
using Entity.Model.Pizza;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Security
{
    public class PedidoController
       : GenericController<
       Pedidos,
       PedidosDto,
       PedidosDto>
    {
        public PedidoController(
            IQueryServices<Pedidos, PedidosDto> q,
            ICommandService<Pedidos, PedidosDto> c)
          : base(q, c) { }
    }

}
