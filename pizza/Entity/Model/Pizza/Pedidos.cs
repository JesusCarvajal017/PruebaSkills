using Entity.Model.Enums;
using Entity.Model.Global;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;


namespace Entity.Model.Pizza
{
    public class Pedidos : ABaseEntity
    {
        public int IdCliente { get; set; }
        public int IdPizza { get; set; }
        public int Amount { get; set; }

        public DateTime DateOrde { get; set; }
        public int Status { get; set; }


        public Cliente Cliente { get; set; }
        public Pizza Pizza { get; set; }
    }
}
