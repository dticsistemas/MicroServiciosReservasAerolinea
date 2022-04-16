using Pedidos.Domain.Model.Pagos.ValueObjetcs;
using Pedidos.Domain.ValueObjects;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Model.Pagos
{
    public class Factura : AggregateRoot<Guid>
    {        
        public Guid ReservaID { get; private set; }
        public PrecioValue Monto { get; private set; }
        public DateTime Fecha { get; private set; }
        public NumeroFactura NroFactura { get; private set; }



        public Factura(Guid reservaId, PrecioValue monto )
        {
            Id = Guid.NewGuid();
            ReservaID = reservaId;
            Monto = monto;
            Fecha = DateTime.Now;
            NroFactura = Convert.ToString(Id);// nroFactura;     // Nro de Factura

        }
        public string getNroFactura()
        {
            return NroFactura;
        }

    }
}
