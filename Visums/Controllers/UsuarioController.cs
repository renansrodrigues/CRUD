using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Visums.Application.Interfaces.Usuario;
using Visums.Application.ViewModel;

namespace Visums.UI.Web.Controllers
{
    public class UsuarioController : Controller
    {
     
        public async Task<IActionResult> Create([FromBody] UsuarioViewModel usuarioViewModel,
            [FromServices] IUsuarioAppService usuarioAppService)
        {

            usuarioAppService.Criar(usuarioViewModel);

            return Ok ();
        }
    }
}
