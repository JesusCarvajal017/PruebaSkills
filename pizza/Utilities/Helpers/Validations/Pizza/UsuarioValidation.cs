using Entity.Dtos.Security.Form;
using Entity.Dtos.Security.Rol;
using Entity.Model.Pizza;
using FluentValidation;

namespace Utilities.Helpers.Validations.Pizza
{
    public class UsuarioValidation : AbstractValidator<Usuario>
    {
        public UsuarioValidation()
        {
            RuleFor(x => x.Name)
           .NotEmpty().WithMessage("El nombre del usuario es obligatorio");
     
        }
    }
}
