using CabineImersivaApi.DTO;
using CabineImersivaApi.Service.Interface;
using CabineImersivaApi.Utils;
using Microsoft.AspNetCore.Mvc;

namespace CabineImersivaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        [HttpPost]
        [Route("cadastroUsuario")]
        public async Task<RespostaPadrao> CadastrarUsuario([FromBody]UsuarioDto usuario)
        {
            return await _usuarioService.CadastrarUsuario(usuario);
        }

    }
}
