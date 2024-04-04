using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogApplication.DataAccess.DataAccessLogApplication
{
    public interface ILogApplicacionData
    {

        /// <summary>
        /// Registra Log aplicacon en base de datos
        /// </summary>
        /// <param name="data_entrada"></param>
        int RegistrarLogAplicacion(LogApplicationDto data_entrada);
    }
}
