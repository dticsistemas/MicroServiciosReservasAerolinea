using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasApplication.Services
{
    public interface IReservaService
    {
        Task<string> GenerarNroReservaAsync();
    }
}
