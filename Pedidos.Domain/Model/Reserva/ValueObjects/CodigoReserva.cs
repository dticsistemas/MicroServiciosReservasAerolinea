using ShareKernel.Core;
using ShareKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Model.Reserva.ValueObjects
{
    public record CodigoReserva : ValueObject
    {
        public string Value { get; }

        public CodigoReserva(string value)
        {
            CheckRule(new StringNotNullOrEmptyRule(value));
            //TODO: validar el formato del codigo de reserva
            Value = value;
        }


        public static implicit operator string(CodigoReserva value)
        {
            return value.Value;
        }

        public static implicit operator CodigoReserva(string value)
        {
            return new CodigoReserva(value);
        }



    }
}
