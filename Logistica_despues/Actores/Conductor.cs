using Logistica_despues.Services.Logistica;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logistica_despues.Actores
{
    internal class Conductor
    {
        private readonly ILogisticaService _logisticaService;

        public Conductor(ILogisticaService logisticaService)
        {
            _logisticaService = logisticaService;
        }

        public void RealizarEntrega(int idPaquete)
        {
            // Otra parte del proceso de recoger el paquete
            var recogido = _logisticaService.RecogerPaquete(idPaquete);

            if (!recogido)
            {
                Console.WriteLine("No se fue posible recibir el paquete");
                return;
            }

            var entregado = _logisticaService.EntregarPaquete(idPaquete);

            Console.WriteLine(entregado ? "Se entrego el paquete bien" : "Murio la entrega");
        }

    }
}
