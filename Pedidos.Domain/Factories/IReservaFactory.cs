using Pedidos.Domain.Model.Reserva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Domain.Factories
{
    public interface IReservaFactory
    {
         Reserva Create(string nroReserva);
    }
}
