using Entity.Model.Enums;
using Entity.Model.Global;


namespace Entity.Model.Pizza
{
    public class Usuario : ABaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Roles Rol { get; set; }
    }
}


