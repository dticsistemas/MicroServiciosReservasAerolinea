using Pedidos.Domain.Model.Reserva;
using Pedidos.Domain.Repositories;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Infraestructura.MemoryRepository
{
    public class MemoryReservaRepository : IReservaRepository
    {
        private readonly MemoryDatabase _database;

        public MemoryReservaRepository(MemoryDatabase database)
        {
            _database = database;
        }

        public Task CreateAsync(Reserva obj)
        {
            _database.Pedidos.Add(obj);
            return Task.CompletedTask;
        }

        public Task<Reserva> FindByIdAsync(Guid id)
        {
            return Task.FromResult(_database.Pedidos.FirstOrDefault(x => x.Id == id));
        }

        public Task RemoveAsync(Reserva obj)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Reserva obj)
        {
            return Task.CompletedTask;
        }

        Task IRepository<Reserva, Guid>.FindByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
