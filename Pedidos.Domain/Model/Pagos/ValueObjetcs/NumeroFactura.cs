using ShareKernel.Core;
using ShareKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Model.Pagos.ValueObjetcs
{
    public record NumeroFactura : ValueObject
    {
        public string Value { get; }

        public NumeroFactura(string value)
        {
            CheckRule(new StringNotNullOrEmptyRule(value));
            //TODO: validar el formato del numero de factura
            Value = value;
        }


        public static implicit operator string(NumeroFactura value)
        {
            return value.Value;
        }

        public static implicit operator NumeroFactura(string value)
        {
            return new NumeroFactura(value);
        }



    }
}