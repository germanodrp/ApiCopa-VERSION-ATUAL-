using ApiCopa_VERSION_ATUAL_.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCopa_VERSION_ATUAL_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfederacoesController : ControllerBase
    {
        public async Task<ActionResult<Confederacoes>> TodosPaises()
        {
            return Ok();
        }
    }
}
