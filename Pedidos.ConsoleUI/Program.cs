using Pedidos.Domain.Model.Clientes;
using Pedidos.Domain.Model.Reserva;
using Pedidos.Domain.Model.Vuelos;
using System;

namespace Reservas.ConsoleUI
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando Proyecto...");
            Cliente cliente = new Cliente("Juan Perez");
            Vuelo vuelo = new Vuelo() ;
            Reserva reserva = new Reserva("DCM144");
            reserva.RegistrarReserva(cliente.Id,vuelo.Id,12m,"contado");
            Console.Write(reserva.ToString());
            Console.WriteLine("........Fin de Proyecto");



        }
    }
}
