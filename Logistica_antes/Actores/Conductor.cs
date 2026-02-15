using Logistica_antes.Sistema;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logistica_antes.Actores
{
    internal class Conductor
    {
        private readonly ISistemaLogistico _sistemaLogistico;

        public Conductor(ISistemaLogistico sistemaLogistico)
        {
            _sistemaLogistico = sistemaLogistico;
        }

        public void RecogerPaquete(int idPaquete)
        {
            _sistemaLogistico.RecogerPaquete(idPaquete);
        }

        public void EntregarPaquete(int idPaquete)
        {
            _sistemaLogistico.EntregarPaquete(idPaquete);
        }
    }
}
