using Entity.Dto.Pizza;
using Entity.Dtos.Security.Form;
using Entity.Dtos.Security.Rol;
using FluentValidation;

namespace Utilities.Helpers.Validations.Pizza
{
    public class PizzaValidation : AbstractValidator<PizzaDto>
    {
        public PizzaValidation()
        {
            RuleFor(x => x.Price)
           .NotEmpty().WithMessage("El precio del la piza es obligatorio");

     
        }
    }
}
