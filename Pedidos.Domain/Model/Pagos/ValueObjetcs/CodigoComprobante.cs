using ShareKernel.Core;
using ShareKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Model.Pagos.ValueObjetcs
{
   public record CodigoComprobante : ValueObject
    {
        public string Value { get; }

        public CodigoComprobante(string value)
        {
            CheckRule(new StringNotNullOrEmptyRule(value));
            //TODO: validar el formato del codigo de reserva
            Value = value;
        }


        public static implicit operator string(CodigoComprobante value)
        {
            return value.Value;
        }

        public static implicit operator CodigoComprobante(string value)
        {
            return new CodigoComprobante(value);
        }



    }
}
