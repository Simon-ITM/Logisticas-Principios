using Logistica_antes.Actores;
using Logistica_antes.Sistema;

namespace Logistica_antes
{
    internal class Program {

        static void Main(string[] args)
        {
            ISistemaLogistico sistemaLogistico = new SistemaLogistico();

            var conductor = new Conductor(sistemaLogistico);
            var contador = new Contador(sistemaLogistico);
            var analistaBodega = new AnalistaBodega(sistemaLogistico);
            var agenteSoporte = new AgenteSoporte(sistemaLogistico);

            Console.WriteLine("Flujo sistema logistico...");

            conductor.RecogerPaquete(101);
            conductor.EntregarPaquete(101);

            analistaBodega.ActualizarStock(Guid.NewGuid(), 50);

            contador.GenerarFactura(5001);
            contador.ProcesarReembolso(5002);

            agenteSoporte.ResolverReclamo(7777);

            Console.Write("Flujo terminado");
        }
    }
}

