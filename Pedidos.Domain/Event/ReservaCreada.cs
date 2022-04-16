using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Event
{
    public record ReservaCreada : DomainEvent
    {
        public Guid ReservaId { get; }
        public ReservaCreada(Guid reservaId
            ) : base(DateTime.Now)
        {
            ReservaId = reservaId;

        }
    }
}
