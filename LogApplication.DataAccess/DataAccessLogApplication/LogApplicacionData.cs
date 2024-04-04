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

        public LogApplicacionData(LogApplicationDbContext logApplicationContext)
        {
            _logApplicationContext = logApplicationContext;
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
                return 0;
            }
        }
    }
}
