using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Visums.Application.Interfaces.Usuario;
using Visums.Application.ViewModel;

namespace Visums.Services.Api.Controllers
{

    public class UsuarioController : ControllerBase
    {

        private readonly IUsuarioAppService _iusuarioAppService;

        public UsuarioController(IUsuarioAppService iusuarioAppService)
        {
            _iusuarioAppService = iusuarioAppService;
        }

        [HttpPost]
        [Route("usuario-criar")]
        public IActionResult Post([FromBody] UsuarioViewModel usuarioViewModel)
        {
            if (!ModelState.IsValid)
            {              
                return BadRequest(usuarioViewModel);
            }

            _iusuarioAppService.Criar(usuarioViewModel);

            return Ok(usuarioViewModel);
        }
    }
}
