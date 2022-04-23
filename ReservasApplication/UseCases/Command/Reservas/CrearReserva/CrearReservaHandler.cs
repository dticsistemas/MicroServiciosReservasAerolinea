using MediatR;
using Microsoft.Extensions.Logging;
using Pedidos.Domain.Repositories;
using Pedidos.Domain.Model.Reserva;
using Reservas.Domain.Factories;
using ReservasApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Reservas.Domain.Repositories;

namespace ReservasApplication.UseCases.Command.Reservas.CrearReserva
{
    public class CrearReservaHandler : IRequestHandler<CrearReservaCommand, Guid>
    {
        private readonly IReservaRepository _reservaRepository;
        private readonly ILogger<CrearReservaHandler> _logger;
        private readonly IReservaService _reservaService;
        private readonly IReservaFactory _reservaFactory;
        private readonly IUnitOfWork _unitOfWork;

        public CrearReservaHandler(IReservaRepository reservaRepository, ILogger<CrearReservaHandler> logger,
            IReservaService reservaService,IReservaFactory reservaFactory, IUnitOfWork unitOfWork)
        {
            _reservaRepository = reservaRepository;
            _logger = logger;
            _reservaService = reservaService;
            _reservaFactory = reservaFactory;
            _unitOfWork = unitOfWork;
        }
        public async Task<Guid> Handle(CrearReservaCommand request, CancellationToken cancellationToken)
        {
            try
            {
                string nroReserva = await _reservaService.GenerarNroReservaAsync();

                Reserva objReserva = _reservaFactory.Create(nroReserva);                
                
                objReserva.RegistrarReserva(request.clienteId, request.vueloId, request.monto, request.tipo);

                await _reservaRepository.CreateAsync(objReserva);

                await _unitOfWork.Commit();

                return objReserva.Id;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al crear Reserva");
            }
            return Guid.Empty;

        }
    }
}
