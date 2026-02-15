using System;
using System.Collections.Generic;
using System.Text;

namespace Logistica_despues.Services.Facturacion
{
    internal interface IFacturacionService
    {
        void GenerarFactura(long idOrden);
        void ProcesarReembolso(long idOrden);
    }
}
