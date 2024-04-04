using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LogApplication.DataAccess.DataAccessLogApplication
{
    [Table("tbl_log_aplicacion", Schema = "log")]
    public class LogApplicationDto
    {
        public LogApplicationDto()
        {

        }

        [Key]
        public int id { get; set; }
        public string? funcion { get; set; }
        public string? componente { get; set; }
        public string? detalle { get; set; }
        public string? data_entrada { get; set; }
        public DateTime fecha_creacion { get; set; }

    }
}
