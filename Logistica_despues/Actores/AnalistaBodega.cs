using Logistica_despues.Services.Inventario;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logistica_despues.Actores
{
    internal class AnalistaBodega
    {
        private readonly IInventarioService _inventarioService;
        
        public AnalistaBodega(IInventarioService inventarioService)
        {
            _inventarioService = inventarioService;
        }

        public void AjustarStock(Guid sku, int cantidad)
        {
            Console.WriteLine("Se van a realizar ajustes en el inventario");

            if (cantidad <= 0)
            {
                Console.WriteLine("Error: No se actualizo el inv");
                return;
            }

            _inventarioService.ActualizarInventario(sku, cantidad);

            Console.WriteLine("El inventario se actualizo correctamente");
        }
    }
}
