using Entity.Dto.Pizza;
using Entity.Dtos.Security.Form;
using FluentValidation;

namespace Utilities.Helpers.Validations.Pizza
{
    public class PedidoValidation : AbstractValidator<PedidosDto>
    {
        public PedidoValidation()
        {
            RuleFor(x => x.Amount)
           .NotEmpty().WithMessage("La cantidad es obligatoria");

         
     
        }
    }
}
