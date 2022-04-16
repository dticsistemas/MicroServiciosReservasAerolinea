using ShareKernel.Core;
using ShareKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Model.Reserva.ValueObjects
{

    public record TipoReserva : ValueObject
    {
        public string Value { get; }

        public TipoReserva(string value)
        {
            CheckRule(new StringNotNullOrEmptyRule(value));
            //TODO: validar el formato del tipo de reserva
            Value = value;
        }


        public static implicit operator string(TipoReserva value)
        {
            return value.Value;
        }

        public static implicit operator TipoReserva(string value)
        {
            return new TipoReserva(value);
        }



    }
}
