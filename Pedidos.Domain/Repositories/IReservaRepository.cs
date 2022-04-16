using Pedidos.Domain.Model.Reserva;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Repositories
{
   
    public interface IReservaRepository : IRepository<Reserva, Guid>
    {
        Task UpdateAsync(Reserva obj);

        Task RemoveAsync(Reserva obj);

    }
}
