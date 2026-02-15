using System;
using System.Collections.Generic;
using System.Text;

namespace Logistica_despues.Services.Logistica
{
    internal interface ILogisticaService
    {
        bool RecogerPaquete(int idPaquete);
        bool EntregarPaquete(int idPaquete);
    }
}
