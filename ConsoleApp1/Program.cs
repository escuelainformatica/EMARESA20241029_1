using ConsoleApp1.modelos;
using ConsoleApp1.servicios;

var clientes = new List<Cliente>
{
    new Cliente("Anna","Smith"),
    new Cliente("Anna","Zoe"),
    new Cliente("Bob","S"),
    new Cliente("John","Doe"),
    new Cliente("Peter","G"),
};

Console.WriteLine("mostrar:");
ClienteSrv.MostrarListado(clientes);

Console.WriteLine("mostrar ordenado:");
ClienteSrv.MostrarListado(ClienteSrv.Ordenar(clientes));

