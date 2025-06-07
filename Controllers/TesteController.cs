using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiTeste.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TesteController : ControllerBase
    {


        private readonly ILogger<TesteController> _logger;

        public TesteController(ILogger<TesteController> logger)
        {
            _logger = logger;
        }


        [HttpGet("ping")]
        public async Task<ActionResult> getPong()
        {
            _logger.LogInformation(" Realizando pingpong com o frontend ");
            return Ok("pong");
        }
    }
}
