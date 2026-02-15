using System;
using System.Collections.Generic;
using System.Text;

namespace Logistica_antes.Sistema
{
    internal class SistemaLogistico : ISistemaLogistico
    {
        public bool RecogerPaquete(int idPaquete)
        {
            if (idPaquete < 0)
            {
                return false;
            }

            Console.WriteLine($"[Logística] Paquete {idPaquete} recogido.");
            return true;
        }

        public bool EntregarPaquete(int idPaquete)
        {
            Console.WriteLine($"[Logística] Paquete {idPaquete} entregado.");
            return true;
        }

        public void ActualizarInventario(Guid sku, int cantidad)
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("Inventario no actualizado");
            }

            Console.WriteLine($"[Inventario] SKU {sku} actualizado en {cantidad} unidades.");
        }

        public void GenerarFactura(long idOrden)
        {
            Console.WriteLine($"[Facturación] Factura generada para la orden {idOrden}.");
        }

        public void ProcesarReembolso(long idOrden)
        {
            Console.WriteLine($"[Facturación] Reembolso procesado para la orden {idOrden}.");
        }

        public void AtenderReclamo(int idTicket)
        {
            Console.WriteLine($"[Soporte] Reclamo {idTicket} atendido.");
        }
    }
}
