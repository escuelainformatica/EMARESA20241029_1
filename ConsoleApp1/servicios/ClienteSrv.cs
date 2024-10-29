using ConsoleApp1.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.servicios
{
    internal class ClienteSrv
    {
        public static List<Cliente> Ordenar(List<Cliente> clientes)
        {
            var resultados = new List<Cliente>();
            resultados = clientes.
                OrderBy(cli => cli.Apellido).
                OrderBy(cli => cli.Nombre).                
                ToList();
            return resultados;
        }
        public static void MostrarListado(List<Cliente> clientes)
        {
            clientes.ForEach(cli => Console.WriteLine($"{cli.Nombre} {cli.Apellido}"));
        }
    }
}
