using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasApplication.UseCases.Command.Clientes.EnviarQrReserva
{
    public class EnviarQrReservaCommand : IRequest<Guid>
    {
    }
}
