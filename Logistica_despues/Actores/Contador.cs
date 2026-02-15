using Logistica_despues.Services.Facturacion;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logistica_despues.Actores
{
    internal class Contador
    {
        private readonly IFacturacionService _facturacionService;

        public Contador(IFacturacionService facturacionService)
        {
            _facturacionService = facturacionService;
        }

        public void TerminarOrden(long idOrden, bool requiereReembolso)
        {
            Console.WriteLine("El contador esta cerrando la orden");

            if (idOrden <= 0)
            {
                Console.Write("Orden invalida");
                return;
            }

            _facturacionService.GenerarFactura(idOrden);

            if (requiereReembolso)
            {
                Console.WriteLine("Se esta solicitando un reembolso");
                _facturacionService.ProcesarReembolso(idOrden);
            }
        }
    }
}
