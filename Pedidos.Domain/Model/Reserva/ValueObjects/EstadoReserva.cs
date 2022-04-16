using ShareKernel.Core;
using ShareKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Model.Reserva.ValueObjects
{

    public record EstadoReserva : ValueObject
    {
        public string Value { get; }

        public EstadoReserva(string value)
        {
            CheckRule(new StringNotNullOrEmptyRule(value));
            //TODO: validar el formato del estado de reserva
            Value = value;
        }


        public static implicit operator string(EstadoReserva value)
        {
            return value.Value;
        }

        public static implicit operator EstadoReserva(string value)
        {
            return new EstadoReserva(value);
        }



    }
}
