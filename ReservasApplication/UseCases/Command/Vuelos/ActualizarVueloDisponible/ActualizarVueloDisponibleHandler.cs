using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReservasApplication.UseCases.Command.Vuelos.ActualizarVueloDisponible
{
    public class ActualizarVueloDisponibleHandler : IRequestHandler<ActualizarVueloDisponibleCommand, Guid>
    {
        public Task<Guid> Handle(ActualizarVueloDisponibleCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
