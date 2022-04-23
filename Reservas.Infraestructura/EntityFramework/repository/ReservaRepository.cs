using Pedidos.Domain.Model.Reserva;
using Pedidos.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Infraestructura.EntityFramework.repository
{
    public class ReservaRepository : IReservaRepository
    {
        public Task CreateAsync(Reserva obj)
        {
            Console.WriteLine($"Insertando la Reserva { obj.CodReserva }");

            return Task.CompletedTask;
        }

        public Task FindByIdAsync(Guid id)
        {
            Console.WriteLine($"Retornando la Reserva { id }");

            return null;
        }

        public Task RemoveAsync(Reserva obj)
        {
            Console.WriteLine($"Removiendo la Reserva{ obj.CodReserva }");

            return null;
        }

        public Task UpdateAsync(Reserva obj)
        {
            Console.WriteLine($"Actualizando la Reserva { obj.CodReserva }");

            return Task.CompletedTask;
        }
    }
}
