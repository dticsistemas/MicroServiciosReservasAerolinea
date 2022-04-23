using Pedidos.Domain.Model.Reserva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Infraestructura.MemoryRepository
{
    public class MemoryDatabase
    {
        private readonly List<Reserva> _reservas;

        public List<Reserva> Pedidos
        {
            get { return _reservas; }
        }

        public MemoryDatabase()
        {
            _reservas = new List<Reserva>();
        }

    }
}
