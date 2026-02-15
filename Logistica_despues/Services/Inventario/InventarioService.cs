using System;
using System.Collections.Generic;
using System.Text;

namespace Logistica_despues.Services.Inventario
{
    internal class InventarioService : IInventarioService
    {
        public void ActualizarInventario(Guid sku, int cantidad)
        {
            Console.WriteLine($"[Inventario] SKU {sku} actualizado en {cantidad} unidades.");
        }
    }
}
