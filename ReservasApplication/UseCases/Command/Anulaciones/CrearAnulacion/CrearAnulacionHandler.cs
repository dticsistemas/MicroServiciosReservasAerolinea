using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReservasApplication.UseCases.Command.Anulaciones.CrearAnulacion
{
    internal class CrearAnulacionHandler : IRequestHandler<CrearAnulacionCommand, Guid>
    {
        public Task<Guid> Handle(CrearAnulacionCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
