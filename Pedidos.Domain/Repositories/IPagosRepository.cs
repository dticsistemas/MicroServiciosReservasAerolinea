using Pedidos.Domain.Model.Pagos;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Domain.Repositories
{
    public interface IPagosRepository : IRepository<Pago, Guid>
    {
        Task UpdateAsync(IPagosRepository obj);

        Task RemoveAsync(IPagosRepository obj);

    }
}
