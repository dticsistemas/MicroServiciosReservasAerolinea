using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasApplication.Dto.Reserva
{
    public class AnulacionDto
    {
        //TODO: Crear value objects para las propiedades
        public Guid ReservaId { get; set; }
        public DateTime Fecha { get; set; }
        public double Importe { get; set; }
        public double Monto { get; set; }
        public String Descripcion { get; set; }

        public AnulacionDto()
        {

        }

    }
}
