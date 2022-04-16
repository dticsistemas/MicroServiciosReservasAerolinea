using Pedidos.Domain.Event;
using Pedidos.Domain.Model.Reserva.ValueObjects;
using Pedidos.Domain.ValueObjects;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Model.Reserva
{
    public class Reserva : AggregateRoot<Guid>
    {

        public Guid ClienteId { get; private set; }
        public Guid VueloId { get; private set; }
        public CodigoReserva CodReserva { get; private set; }
        public EstadoReserva Estado { get; private set; }
        public PrecioValue Monto { get; private set; }
        public DateTime Fecha { get; private set; }
        public TipoReserva Tipo { get; private set; }


        public Reserva(string codReserva)
        {
            Id = Guid.NewGuid();
            CodReserva = codReserva;
            Monto = new PrecioValue(0m);
        }
        public void RegistrarReserva(Guid clienteID, Guid vueloId, decimal monto, String tipo)
        {

            if (VerificarDisponibilidad(vueloId))
            {
                Monto = Monto;
                ClienteId = clienteID;
                VueloId = vueloId;
                Fecha = DateTime.Now;
                Estado = "pendiente";
                Tipo = tipo;
                //Enviar QR al cliente con el monto
                AddDomainEvent(new ReservaCreada(Id));
            }
            else
            {
                // Generar exception Not Asientos vuelos Disponibles
                Console.WriteLine("NO Existen asientos Disponibles");
            }
        }
        public void CancelarReserva(decimal importe,String descripcion)
        {
            var anulacion = new Anulacion(Id, importe, Monto, descripcion);
            //Enviar mensaje de cancelacion de reserva
            AddDomainEvent(new ReservaCancelada(Id));


        }
        internal bool VerificarDisponibilidad(Guid vueloId)
        {
            //Verificacion de asientos disponibles sin reservados
            Console.WriteLine("Verificando si vuelo tiene asientos disponibles");
            return true;
        }
        public void VigenciarReservas()
        {
            //Revision de las vigencia con estado Pendiente
            Console.WriteLine("Actualizando estado a cancelado");
        }
        public void ConfirmarVentaReserva()
        {
            Estado = "Pagado";
            Console.WriteLine("Actualizando estado a pagado");
        }

    }
}
