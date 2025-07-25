using Entity.Model.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model.Pizza
{
    public class Cliente : ABaseEntity
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
    }

}

