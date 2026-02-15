using Logistica_antes.Sistema;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logistica_antes.Actores
{
    internal class Contador
    {
        private readonly ISistemaLogistico _sistemaLogistico;

        public Contador(ISistemaLogistico sistemaLogistico)
        {
            _sistemaLogistico = sistemaLogistico;
        }

        public void GenerarFactura(long idOrden)
        {
            _sistemaLogistico.GenerarFactura(idOrden);
        }

        public void ProcesarReembolso(long idOrden)
        {
            _sistemaLogistico.ProcesarReembolso(idOrden);
        }
    }
}
