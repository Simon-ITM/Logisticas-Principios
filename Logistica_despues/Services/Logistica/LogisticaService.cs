using System;
using System.Collections.Generic;
using System.Text;

namespace Logistica_despues.Services.Logistica
{
    internal class LogisticaService : ILogisticaService
    {
        public bool EntregarPaquete(int idPaquete)
        {
            if (idPaquete == null || idPaquete <= 0)
                return false;

            Console.Write($"[Logística] Paquete {idPaquete} recogido.");
            return true;
        }

        public bool RecogerPaquete(int idPaquete)
        {
            Console.WriteLine($"[Logística] Paquete {idPaquete} entregado.");
            return true;
        }
    }
}
