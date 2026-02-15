using Logistica_antes.Sistema;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logistica_antes.Actores
{
    internal class AgenteSoporte
    {
        private readonly ISistemaLogistico _sistemaLogistico;

        public AgenteSoporte(ISistemaLogistico sistemaLogistico)
        {
            _sistemaLogistico = sistemaLogistico;
        }

        public void ResolverReclamo(int idTicket)
        {
            _sistemaLogistico.AtenderReclamo(idTicket);
        }
    }
}
