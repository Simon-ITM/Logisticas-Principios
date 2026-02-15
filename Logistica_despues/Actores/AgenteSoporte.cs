using Logistica_despues.Services.Soporte;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logistica_despues.Actores
{
    internal class AgenteSoporte
    {
        private readonly ISoporteService _soporteService;

        public AgenteSoporte(ISoporteService soporteService)
        {
            _soporteService = soporteService;
        }

        public void GestionarReclamo(int idTicket)
        {
            Console.WriteLine("Se va a revisar un reclamo");

            if (idTicket == null)
            {
                Console.WriteLine("Ticket invalido");
                return;
            }

            _soporteService.AtenderReclamo(idTicket);
            Console.WriteLine("Reclamo resuelto/atendido");
        }
    }
}
