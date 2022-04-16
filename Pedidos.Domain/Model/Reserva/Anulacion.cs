using Pedidos.Domain.ValueObjects;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Model.Reserva
{
    public class Anulacion : AggregateRoot<Guid>
    {

        //TODO: Crear value objects para las propiedades
        public Guid ReservaId { get; private set; }
        public DateTime Fecha{ get; private set; }
        public PrecioValue Importe { get; private set; }
        public PrecioValue Monto{ get; private set; }
        public String Descripcion { get; private set; }

        internal Anulacion(Guid reservaId, decimal importe, decimal monto, String descripcion)
        {
            Id = Guid.NewGuid();
            Importe = Importe;
            Monto = monto;
            Fecha = DateTime.Now;
            Descripcion = descripcion;
        }
        internal void ModificarAnulacion(decimal importe, decimal monto,String descripcion)
        {
            Importe = importe;
            Monto = monto;
            Descripcion = descripcion;
        }

    }
}
