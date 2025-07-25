using Entity.Context.Main;
using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implements.Pizza
{
    public class LoginData
    {
        private readonly AplicationDbContext _context;

        public LoginData(AplicationDbContext context)
        {
            _context = context;
        }

        public bool ValidarUsuario(LoginDto login)
        {
            var existe = _context.Usuario
                .Any(u => u.Name == login.Name  && u.Password == login.Password);

            return existe;
        }

    }
}
