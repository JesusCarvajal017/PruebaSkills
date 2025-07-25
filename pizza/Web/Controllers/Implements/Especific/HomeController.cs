using Data.Implements.Pizza; // Donde está tu clase Login
using Entity.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class LoginController : Controller
    {
        private readonly LoginData _loginService;

        public LoginController(LoginData loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        public IActionResult Validar([FromBody] LoginDto LoginDto)
        {
            bool esValido = _loginService.ValidarUsuario(LoginDto);

            if (esValido)
            {
                // Aquí puedes redirigir al dashboard o devolver un JSON
                return Ok(new { status = esValido });
            }
            else
            {
                return Unauthorized(new { status = esValido });
            }
        }
    }
}
