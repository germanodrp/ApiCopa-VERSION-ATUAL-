using ApiCopa_VERSION_ATUAL_.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCopa_VERSION_ATUAL_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PotesController : ControllerBase
    {
        public async Task<ActionResult<Potes>> TodosPotes()
        {
            return Ok();
        }
    }
}
