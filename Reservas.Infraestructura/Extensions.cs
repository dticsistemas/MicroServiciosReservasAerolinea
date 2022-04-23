using Microsoft.Extensions.DependencyInjection;
using Pedidos.Domain.Repositories;
using Reservas.Domain.Repositories;
using Reservas.Infraestructura.EntityFramework;
using Reservas.Infraestructura.MemoryRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Infraestructura
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            //TODO: Eliminar despues. Solo para proposito de pruebas
            services.AddSingleton<MemoryDatabase>();

            services.AddScoped<IReservaRepository, MemoryReservaRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();


            return services;
        }

    }
}
