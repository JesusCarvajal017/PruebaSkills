using Entity.Dtos.Global;
using Entity.Model.Enums;
using Entity.Model.Global;


namespace Entity.Dto.Pizza
{
    public class UsuarioDto : ABaseDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Rol { get; set; }


    }
}


