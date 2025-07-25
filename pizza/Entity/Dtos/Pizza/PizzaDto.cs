using Entity.Dtos.Global;
using Entity.Model.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dto.Pizza
{
    public class PizzaDto : ABaseDto
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Adress { get; set; }
    }

}

