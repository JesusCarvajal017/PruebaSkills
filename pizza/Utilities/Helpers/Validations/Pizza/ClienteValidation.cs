using Entity.Dto.Pizza;
using Entity.Dtos.Security.Form;
using Entity.Dtos.Security.Rol;
using FluentValidation;

namespace Utilities.Helpers.Validations.Pizza
{
    public class ClienteValidation : AbstractValidator<ClienteDto>
    {
        public ClienteValidation()
        {
            RuleFor(x => x.Name)
           .NotEmpty().WithMessage("El nombre del formulario es obligatorio");

          
     
        }
    }
}
