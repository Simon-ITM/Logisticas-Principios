using Logistica_antes.Sistema;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logistica_antes.Actores
{
    internal class AnalistaBodega
    {
        private readonly ISistemaLogistico _sistemaLogistico;

        public AnalistaBodega(ISistemaLogistico sistemaLogistico)
        {
            _sistemaLogistico = sistemaLogistico;
        }

        public void ActualizarStock(Guid sku, int cantidad)
        {
            _sistemaLogistico.ActualizarInventario(sku, cantidad);
        }


    }
}
