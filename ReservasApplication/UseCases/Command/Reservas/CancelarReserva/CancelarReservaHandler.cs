using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReservasApplication.UseCases.Command.Reservas.CancelarReserva
{
    public class CancelarReservaHandler : IRequestHandler<CancelarReservaCommand, Guid>
    {
        public Task<Guid> Handle(CancelarReservaCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
