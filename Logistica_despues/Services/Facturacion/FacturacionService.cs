using System;
using System.Collections.Generic;
using System.Text;

namespace Logistica_despues.Services.Facturacion
{
    internal class FacturacionService : IFacturacionService
    {
        public void GenerarFactura(long idOrden)
        {
            Console.WriteLine($"[Facturación] Factura generada para la orden {idOrden}.");
        }

        public void ProcesarReembolso(long idOrden)
        {
            Console.WriteLine($"[Facturación] Reembolso procesado para la orden {idOrden}.");
        }
    }
}
