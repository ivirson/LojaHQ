using System.Linq;
using Blog.API.Services;
using Ivirson.LojaHQ.Data;
using Ivirson.LojaHQ.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.API.Controllers
{
    [Route("api/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly DataContext _context;

        public LoginController(DataContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Método que retorna um usuário logado e um token de autenticação
        /// </summary>
        /// <param name="model">Informações do Usuario a logar</param>
        /// <returns>
        /// Em caso de sucesso, retorna o Usuário autenticado e um token
        /// Em caso de erro, retorna 404 (Not Found)
        /// </returns>
        [HttpPost]
        public IActionResult Autenticar([FromBody] Usuario model)
        {
            // Recupera o usuário
            var usuario = _context.Usuarios.FirstOrDefault(x => x.Login == model.Login && x.Senha ==  model.Senha);

            // Verifica se o usuário existe
            if (usuario == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            // Gera o Token
            var token = TokenService.GenerateToken(usuario);

            // Oculta a senha
            usuario.Senha = "";

            // Retorna os dados
            return Ok(
                new
                {
                    usuario = usuario,
                    token = token
                }
            );
        }
    }
}
