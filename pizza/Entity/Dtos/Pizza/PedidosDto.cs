using Entity.Dtos.Global;
using Entity.Model.Enums;
using Entity.Model.Global;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;


namespace Entity.Dto.Pizza
{
    public class PedidosDto : ABaseDto
    {
        public int IdCliente { get; set; }
        public int IdPizza { get; set; }
        public int Amount { get; set; }

        public DateTime DateOrde { get; set; }
        public int Status { get; set; }
    }
}
