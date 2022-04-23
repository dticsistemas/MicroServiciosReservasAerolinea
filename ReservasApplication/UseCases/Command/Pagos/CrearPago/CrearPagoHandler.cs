using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReservasApplication.UseCases.Command.Pagos.CrearPago
{
    //private readonly int ss;
    public class CrearPagoHandler : IRequestHandler<CrearPagoCommand, Guid>
    {

        public Task<Guid> Handle(CrearPagoCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
