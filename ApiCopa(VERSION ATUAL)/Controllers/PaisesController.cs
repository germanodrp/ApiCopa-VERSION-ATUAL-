using ApiCopa_VERSION_ATUAL_.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCopa_VERSION_ATUAL_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisesController : ControllerBase
    {
        [HttpGet("obterPaises")]

        public async Task<ActionResult<Paises>> TodosPaises()
        {
            try
            {

            }
            catch
            {

            }
        }
    }
}
