using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dto.Pizza;
using Entity.Dtos.Security.Form;
using Entity.Model.Pizza;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.Security
{
    public class UsuarioController
       : GenericController<
       Usuario,
       UsuarioDto,
       UsuarioDto>
    {
        public UsuarioController(
            IQueryServices<Usuario, UsuarioDto> q,
            ICommandService<Usuario, UsuarioDto> c)
          : base(q, c) { }
    }

}
