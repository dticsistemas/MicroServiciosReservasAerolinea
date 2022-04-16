using Pedidos.Domain.Model.Pagos.ValueObjetcs;
using Pedidos.Domain.ValueObjects;
using Reservas.Domain.Event;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Model.Pagos
{
    public class Pago : AggregateRoot<Guid>
    {
        public Guid ReservaId { get; private set; }
        public PrecioValue Monto { get; private set; }
        public DateTime Fecha { get; private set; }
        public CodigoComprobante CodComprobante { get; private set; }

        public Pago()
        {
            Id = Guid.NewGuid();
            Monto = new PrecioValue(0m);

        }
        public void RegistrarPago(Guid reservaId, decimal monto)
        {
            //Obtener Monto a pagar
            decimal montoTotal = CalcularMontoTotal(reservaId);
            decimal montoPagado = CalcularMontoPagado(reservaId);
            //Verificar Deuda 
            decimal montoDeuda = montoTotal - montoPagado;
            //Validar pago Completa
            if (monto < montoDeuda)
            {
                // Generar Comprobante Recibo           
            }
            else
            {
                if (monto == montoDeuda)
                {
                    // Generar NRO Factura
                    Factura factura = new Factura(reservaId, monto);
                    string nroFactura = factura.getNroFactura();
                    AddDomainEvent(new ReservaPagada(reservaId));

                }
                else { 
                    // Error de pago excede deuda

                }
            } 
            

        }
        public decimal CalcularMontoPagado(Guid reservaId)
        {
            decimal deuda = 0m;
            decimal montopagado = 0m;
            deuda = deuda + montopagado;
            return deuda;
        }
        internal decimal CalcularMontoTotal(Guid reservaId)
        {
            decimal montoTotal = 0m;
            return montoTotal;
        }
        
    }
}