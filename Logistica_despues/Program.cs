using Logistica_despues.Actores;
using Logistica_despues.Services.Facturacion;
using Logistica_despues.Services.Inventario;
using Logistica_despues.Services.Logistica;
using Logistica_despues.Services.Soporte;

namespace Logistica_despues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Servicios cohesivos
            ILogisticaService logistica = new LogisticaService();
            IInventarioService inventario = new InventarioService();
            IFacturacionService facturacion = new FacturacionService();
            ISoporteService soporte = new SoporteService();

            // Actores
            var conductor = new Conductor(logistica);
            var contador = new Contador(facturacion);
            var analista = new AnalistaBodega(inventario);
            var agente = new AgenteSoporte(soporte);

            Console.WriteLine("=== Flujo V2 ===");

            conductor.RealizarEntrega(101);
            analista.AjustarStock(Guid.NewGuid(), 30);
            contador.TerminarOrden(777, false);
            agente.GestionarReclamo(3001);

            Console.WriteLine("=== Fin ===");
        }
    }
}