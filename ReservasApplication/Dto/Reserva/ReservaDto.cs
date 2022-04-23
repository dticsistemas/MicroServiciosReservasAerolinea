using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasApplication.Dto.Reserva
{
    public class ReservaDto
    {
        public Guid ClienteId { get; set; }
        public Guid VueloId { get; set; }
        public int CodReserva { get; set; }
        public String Estado { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public String Tipo { get; set; }
        public ReservaDto()
        {
        }

    }
}
