using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dto.Pizza;
using Entity.Dtos.Security.Form;
using Entity.Model.Pizza;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Security
{
    public class ClienteController
       : GenericController<
       Cliente,
       ClienteDto,
       ClienteDto>
    {
        public ClienteController(
            IQueryServices<Cliente, ClienteDto> q,
            ICommandService<Cliente, ClienteDto> c)
          : base(q, c) { }
    }

}
