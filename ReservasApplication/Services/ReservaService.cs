using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasApplication.Services
{
    public class ReservaService : IReservaService
    {
        public Task<string> GenerarNroReservaAsync()
        {
            return Task.FromResult("ABC");
        }

    }
}
