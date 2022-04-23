using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasApplication.Dto.Pagos
{
    public class PagoDto
    {
        public Guid ReservaId { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public String CodComprobante { get; set; }
    }
}
