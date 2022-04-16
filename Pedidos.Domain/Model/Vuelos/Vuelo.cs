using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Model.Vuelos
{
    public class Vuelo : AggregateRoot<Guid>
    {

        public Vuelo()
        {
            Id = Guid.NewGuid();
        }


    }
}
