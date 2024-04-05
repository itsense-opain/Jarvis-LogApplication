using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogApplication.DataAccess.DataAccessLogApplication
{
    public  class LogApplicacionData : ILogApplicacionData
    {

        private readonly LogApplicationDbContext _logApplicationContext;
        private readonly ILogger<LogApplicationDbContext> _logger;

        public LogApplicacionData(LogApplicationDbContext logApplicationContext, ILogger<LogApplicationDbContext> logger)
        {
            _logApplicationContext = logApplicationContext;
            _logger = logger;
        }


        /// <summary>
        /// Registra Log aplicacon en base de datos
        /// </summary>
        /// <param name="data_entrada"></param>
        public int RegistrarLogAplicacion(LogApplicationDto data_entrada)
        {
            try
            {
                _logApplicationContext.LogAplicaciones.Add(data_entrada);
                _logApplicationContext.SaveChanges();
                return data_entrada.id;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error [500] Internal Server Error: Se detuvo el sistema por el siguiente error inesperado: " + ex.Message);
                return 0;
            }
        }
    }
}
