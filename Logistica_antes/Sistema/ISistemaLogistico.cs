using System;
using System.Collections.Generic;
using System.Text;

namespace Logistica_antes.Sistema
{
    internal interface ISistemaLogistico
    {
        bool RecogerPaquete(int idPaquete);
        bool EntregarPaquete(int idPaquete);
        void ActualizarInventario(Guid sku, int cantidad); // SKU (stock keeping unit)
        void GenerarFactura(long idOrden);
        void ProcesarReembolso(long idOrden);
        void AtenderReclamo(int idTicket);
    }
}
