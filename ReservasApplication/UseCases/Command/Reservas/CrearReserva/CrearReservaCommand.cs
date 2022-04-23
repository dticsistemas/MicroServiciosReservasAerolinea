using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasApplication.UseCases.Command.Reservas.CrearReserva
{
    public class CrearReservaCommand:IRequest<Guid>
    {
        public Guid clienteId { get; set; }
        public Guid vueloId { get; set; }
        public decimal monto{ get; set; }
        public String tipo{ get; set; }

        public CrearReservaCommand(Guid clienteId, Guid vueloId, decimal monto,String tipo)
        {
            this.clienteId = clienteId;
            this.vueloId = vueloId;
            this.monto = monto;
            this.tipo = tipo;
        }
    }
}
