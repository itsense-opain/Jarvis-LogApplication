using LogApplication.DataAccess.DataAccessLogApplication;
using Microsoft.AspNetCore.Mvc;

namespace MS_LogApplicationServices.Controllers
{
    [Route("api/[controller]")]
    public class LogApplicationController : ControllerBase
    {

        private readonly ILogApplicacionData _logApplicacionData;

        public LogApplicationController(ILogApplicacionData logApplicacionData)
        {
            _logApplicacionData = logApplicacionData;
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
