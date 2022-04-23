using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReservasApplication.UseCases.Command.Clientes.EnviarQrReserva
{
    public class EnviarQrReservaHandler : IRequestHandler<EnviarQrReservaCommand, Guid>
    {
        public Task<Guid> Handle(EnviarQrReservaCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
