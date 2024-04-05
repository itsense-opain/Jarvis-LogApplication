using LogApplication.DataAccess.DataAccessLogApplication;
using Microsoft.AspNetCore.Mvc;

namespace MS_LogApplicationServices.Controllers
{
    [Route("api/[controller]")]
    public class LogApplicationController : ControllerBase
    {

        private readonly ILogApplicacionData _logApplicacionData;
        private readonly ILogger<LogApplicationController> _logger;

        public LogApplicationController(ILogApplicacionData logApplicacionData, ILogger<LogApplicationController> logger)
        {
            _logApplicacionData = logApplicacionData;
            _logger = logger;
        }

        /// <summary>
        /// Crear Prospecto
        /// </summary>
        /// <param name="datos_entrada">Modelo Prospecto cifrado</param>
        [HttpPost]
        [Route("RegistrarLogAplicacion")]
        public async Task<ActionResult<string>> RegistrarLogAplicacion([FromBody] LogApplicationDto datos_entrada)
        {
            return Ok(_logApplicacionData.RegistrarLogAplicacion(datos_entrada));
        }
    }
}
