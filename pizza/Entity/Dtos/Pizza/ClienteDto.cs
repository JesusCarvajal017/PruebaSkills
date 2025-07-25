using Entity.Dtos.Global;
using Entity.Model.Global;


namespace Entity.Dto.Pizza
{
    public class ClienteDto : ABaseDto
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
    }

}

