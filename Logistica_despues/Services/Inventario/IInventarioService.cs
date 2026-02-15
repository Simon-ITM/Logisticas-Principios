using System;
using System.Collections.Generic;
using System.Text;

namespace Logistica_despues.Services.Inventario
{
    internal interface IInventarioService
    {
        void ActualizarInventario(Guid sku, int cantidad);
    }
}
