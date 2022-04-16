using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Domain.Event
{
    public record ReservaPagada : DomainEvent
    {
        public Guid ReservaId { get; }
        public ReservaPagada(Guid reservaId
            ) : base(DateTime.Now)
        {
            ReservaId = reservaId;

        }
    }
}
