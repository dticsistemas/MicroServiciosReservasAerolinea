using Pedidos.Domain.Model.Reserva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Domain.Factories
{
    public class ReservaFactory:IReservaFactory
    {
        public Reserva Create(string nroReserva)
        {
            return new Reserva(nroReserva);
        }
    }
}
