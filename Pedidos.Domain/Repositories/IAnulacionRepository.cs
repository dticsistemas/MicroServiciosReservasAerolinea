
using Pedidos.Domain.Model.Reserva;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Repositories
{

    public interface IAnulacionRepository : IRepository<Anulacion, Guid>
    {
        Task UpdateAsync(Anulacion obj);

        Task RemoveAsync(Anulacion obj);

    }
}
