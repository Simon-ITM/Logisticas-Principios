using System;
using System.Collections.Generic;
using System.Text;

namespace Logistica_despues.Services.Soporte
{
    internal class SoporteService : ISoporteService
    {
        public void AtenderReclamo(int idTicket)
        {
            Console.WriteLine($"[Soporte] Reclamo {idTicket} atendido.");
        }
    }
}
